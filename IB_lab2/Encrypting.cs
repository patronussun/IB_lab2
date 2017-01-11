using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_lab2
{
    public static class Encrypting
    {
        private static byte[,] Sblocks = {
                            {4, 10, 9, 2, 13, 8, 0, 14, 6, 11, 1, 12, 7, 15, 5, 3},
                            {14, 11, 4, 12, 6,  13, 15, 10, 2,  3,  8,  1,  0,  7,  5,  9},
                            {5, 8,1, 13, 10, 3, 4, 2, 14, 15, 12, 7, 6, 0,  9,  11},
                            {7, 13, 10, 1, 0, 8 ,9  ,15, 14, 4, 6, 12,  11, 2,  5,  3},
                            {6, 12, 7,  1,  5,  15, 13, 8,  4,  10, 9,  14, 0,  3,  11, 2},
                            {4, 11, 10, 0,  7,  2,  1,  13, 3,  6,  8,  5,  9,  12, 15, 14},
                            {13, 11, 4,  1,  3,  15, 5,  9,  0,  10, 14, 7,  6,  8,  2,  12},
                            {1, 15, 13, 0,  5,  7,  10, 4,  9,  2,  3,  14, 6,  11, 8,  12}
                          };

        public static string KEY = "";
        public static string Syncro_package = "";

        private static bool mod64(int length)
        {
            if ((length % 8) == 0)
                return true;
            else
                return false;
        }

        private static List<UInt64> BlocksListData(string data)
        {
            List<UInt64> resultList = new List<UInt64>();
            byte[] temp = Encoding.Default.GetBytes(data);
            int startIndex = 0;
            while (startIndex < temp.Length)
            {
                resultList.Add(BitConverter.ToUInt64(temp, startIndex));
                startIndex += 8;
            }
            return resultList;
        }

        private static List<UInt32> ListKeyparts32bit(string key)
        {
            List<UInt32> resultList = new List<UInt32>();
            byte[] temp = Encoding.Default.GetBytes(key);
            resultList.Add(BitConverter.ToUInt32(temp, 0));
            resultList.Add(BitConverter.ToUInt32(temp, 4));
            resultList.Add(BitConverter.ToUInt32(temp, 8));
            resultList.Add(BitConverter.ToUInt32(temp, 12));
            resultList.Add(BitConverter.ToUInt32(temp, 16));
            resultList.Add(BitConverter.ToUInt32(temp, 20));
            resultList.Add(BitConverter.ToUInt32(temp, 24));
            resultList.Add(BitConverter.ToUInt32(temp, 28));
            return resultList;
        }

        private static UInt32 mod2_32(UInt32 a, UInt32 b)
        {
            UInt32 result = a + b;
            return result;
        }

        private static UInt32 shiftN(UInt32 num, int n)
        {
            return (UInt32)(num << 11) | (num >> 21);
        }

        private static UInt32 LeftPart(UInt64 data) //старшие биты
        {
            data >>= 32;
            UInt32 result = (UInt32)data;
            return result;
        }

        private static UInt32 RightPart(UInt64 data) //младшие биты 
        {
            UInt32 result = (UInt32)data;
            return result;
        }

        private static UInt32 func_Feistel(UInt32 R, UInt32 Ki)
        {
            UInt32 s = mod2_32(R, Ki);
            List<UInt32> partsS = new List<UInt32>();
            for (int i = 0; i < 8; ++i)
            {
                UInt32 temp = s >> 28;
                partsS.Add(temp);
                s <<= 4;
            }
            partsS.Reverse();
            for (int i = 0; i < 8; ++i)
            {
                partsS[i] = Sblocks[i, (int)partsS[i]];
            }
            s = 0;
            for (int i = 0; i < partsS.Count; ++i)
            {
                s += partsS[i];
                s <<= 4;
            }
            s = shiftN(s, 11);
            return s;
        }

        private static UInt64 feistel(UInt64 partData, UInt32 partKey)//осуществляет шаг в сети Фейстеля
        {
            UInt32 L = LeftPart(partData);
            UInt32 R = RightPart(partData);
            UInt32 temp = func_Feistel(R, partKey);
            UInt32 xor = L ^ temp;
            UInt64 result = (UInt64)R;
            result <<= 32;
            result += (UInt64)xor;
            return result;
        }

        /// <summary>
        /// Шифрует 64-битный блок
        /// </summary>
        /// <param name="partData">блок данных</param>
        /// <param name="partsKey">32-битный блок ключа</param>
        /// <returns></returns>
        private static UInt64 encodePartData(UInt64 partData, List<UInt32> partsKey)
        {
            for (int i = 0; i < 24; ++i)
            {
                partData = feistel(partData, partsKey[i % 8]);
            }
            for (int i = 7; i >= 0; --i)
            {
                partData = feistel(partData, partsKey[i]);
            }
            UInt64 result = (partData << 32) + (partData >> 32);
            return result;
        } 

        /// <summary>
        /// Расшифровывает блок данных
        /// </summary>
        /// <param name="partData">64 ьитный блок данных</param>
        /// <param name="partsKey">32 битный блок ключа</param>
        /// <returns></returns>
        private static UInt64 decodePartData(UInt64 partData, List<UInt32> partsKey)
        {
            for (int i = 0; i < 8; ++i)
            {
                partData = feistel(partData, partsKey[i]);
            }
            for (int i = 23; i >= 0; --i)
            {
                partData = feistel(partData, partsKey[i % 8]);
            }
            UInt64 result = (partData << 32) + (partData >> 32);
            return result;
        }

        public static string encode(string data, string key)
        {
            if (!mod64(data.Length))
            {
                while (!mod64(data.Length))
                {
                    data += "\0";
                }
            }
            List<UInt32> partsKey = ListKeyparts32bit(key);
            List<UInt64> partsData = BlocksListData(data);
            List<UInt64> encodedData = new List<UInt64>();
            string result = "";
            for (int i = 0; i < partsData.Count; ++i)
            {
                string S_pack = Syncro_package;
                UInt64 encoded_synchro_package = encodePartData(BlocksListData(S_pack)[0], partsKey);
                encodedData.Add(encoded_synchro_package ^ partsData[i]);
                S_pack = getPartString(encoded_synchro_package ^ partsData[i]);
            }
            for (int i = 0; i < encodedData.Count; ++i)
            {
                result += getPartString(encodedData[i]);
            }
            return result;

        }

        private static string getPartString(UInt64 partText)
        {
            byte[] temp = BitConverter.GetBytes(partText);
            string result = Encoding.Default.GetString(temp);
            return result;
        }

        public static string decode(string codedData, string key)
        {
            List<UInt32> partsKey = ListKeyparts32bit(key);
            List<UInt64> partsData = BlocksListData(codedData);
            List<UInt64> decodedData = new List<UInt64>();
            string result = "";
            for (int i = 0; i < partsData.Count; ++i)
            {
                string S_pack = Syncro_package;
                UInt64 encoded_synchro_package = encodePartData(BlocksListData(S_pack)[0], partsKey);
                decodedData.Add(encoded_synchro_package ^ partsData[i]);
                S_pack = getPartString(encoded_synchro_package ^ partsData[i]);
            }
            for (int i = 0; i < decodedData.Count; ++i)
            {
                result += getPartString(decodedData[i]);
            }
            return result;
        }
    }
}
