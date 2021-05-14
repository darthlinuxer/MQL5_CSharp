using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;

namespace MQL5
{
    public class Forced
    {
        [DllExport("Add", CallingConvention = CallingConvention.StdCall)]
        public static int Add(int x, int y) => x + y;

        [DllExport("Soma", CallingConvention = CallingConvention.StdCall)]
        public static float Sum([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] x, int size) => x.Sum();

        [DllExport]
        public static float Media([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] x, int size) => x.Sum() / x.Count();


        [DllExport("GetFiboArray", CallingConvention = CallingConvention.StdCall)]
        public static void GetFiboArray([In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] long[] res, int size)
        // Se elementos alterados devem ser retornados ao MetaTrader (passando por referência), é suficiente colocar atributos [In, Out,] antes do atributo MarshalAs.
        {
            res[0] = 0;
            res[1] = 1;
            if (size < 3) return;
            for (int i = 2; i < size; i++)
                res[i] = res[i - 1] + res[i - 2];
        }

        [DllExport("ReplaceString", CallingConvention = CallingConvention.StdCall)]
        public static int ReplaceString([In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder str,
       [MarshalAs(UnmanagedType.LPWStr)] string a, [MarshalAs(UnmanagedType.LPWStr)] string b)
        {
            str.Replace(a, b);

            if (str.ToString().Contains(a)) return 1;
            else return 0;
        }

        private static List<MqlTick> list;

        //https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.structlayoutattribute.pack?redirectedfrom=MSDN&view=net-5.0
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct MqlTick
        {
            public Int64 Time;
            public Double Bid;
            public Double Ask;
            public Double Last;
            public UInt64 Volume;
        }

        [DllExport("AddTick", CallingConvention = CallingConvention.StdCall)]
        public static int AddTick(ref MqlTick tick, ref double bidsum)
        {
            bidsum = 0.0;

            if (list == null) list = new List<MqlTick>();

            tick.Volume = 666;
            list.Add(tick);

            foreach (MqlTick t in list) bidsum += t.Ask;

            return list.Count;
        }

    }

}
