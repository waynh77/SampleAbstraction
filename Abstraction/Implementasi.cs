
namespace Abstraction
{
    internal class Implementasi:Abstract
    {
        public override void ShowDataPribadi(string? nama, string? alamat, string? telp)
        {
            Console.WriteLine("Data Pribadi");
            Console.WriteLine();
            Console.WriteLine("Nama : {0}", nama);
            Console.WriteLine("Alamat : {0}", alamat);
            Console.WriteLine("Telp : {0}", telp);
            Console.WriteLine();
        }
    }
}
