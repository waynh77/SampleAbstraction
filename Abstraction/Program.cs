using Abstraction;

Implementasi data=new();

string? nama ;
string? alamat;
string? telp;
string? jeniskelamin;
int usia;

Console.Write("Masukan Nama : ");
nama = Console.ReadLine();
Console.Write("Masukan Alamat : ");
alamat = Console.ReadLine();
Console.Write("Masukan Telp : ");
telp = Console.ReadLine();
Console.Write("Masukan Jenis Kelamin : ");
jeniskelamin = Console.ReadLine();
Console.Write("Masukan Usia :");
usia =Convert.ToInt32(Console.ReadLine());

data.ShowDataPribadi(nama, alamat, telp);
global::Abstraction.Abstract.ShowDataUmum(nama,jeniskelamin, usia);

Console.ReadKey(true);