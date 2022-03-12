using System;
namespace Praktikum_3
{
    public class KodeBuah
    {
        public enum Buah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            BlackBerry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        public static string getKodeBuah(Buah inputNamaBuah)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

            return kodeBuah[(int)inputNamaBuah];
        }
    }
}
