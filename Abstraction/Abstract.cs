
namespace Abstraction
{
    internal abstract class Abstract
    {
        public abstract void ShowDataPribadi(string? nama, 
            string? alamat, string? telp);

        public static void ShowDataUmum(string? nama,
            string? jeniskelamin,int usia)
        {
            Console.WriteLine("Data Umum");
            Console.WriteLine();
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("Jenis Kelamin : {0}", 
                jeniskelamin);
            Console.WriteLine("Usia : {0}", usia);
            Console.WriteLine();
        }
    }
}
