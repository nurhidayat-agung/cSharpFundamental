using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDBWithConsole.CRUD;
using LocalDBWithConsole.model;

namespace LocalDBWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            mulai:
            CRUDLocalDB crudLocalDb = new CRUDLocalDB();
            UserLocalDB userLocalDb = new UserLocalDB();
            Console.WriteLine("===== Menu CRUD with Console :v =====");
            Console.WriteLine("============= CMD = Laki ============");
            Console.WriteLine("Silahkan Pilih Menu :");
            Console.WriteLine("1. select data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Detele");
            Console.Write("masukan pilihan : ");
            string pil = Console.ReadLine();
            int a = 0;
            if (int.TryParse(pil, out a))
            {
                
                switch (Int16.Parse(pil))
                {
                    case 1:
                        Console.WriteLine("+++ Menu Insert +++");
                        crudLocalDb.showData();
                        break;

                    case 2:
                        Console.WriteLine("+++ Menu Select +++");
                        Console.Write("masukan Username : ");
                        userLocalDb.username = Console.ReadLine();
                        Console.Write("masukan Password : ");
                        userLocalDb.password = Console.ReadLine();
                        if (crudLocalDb.pushUser(userLocalDb))
                        {
                            Console.WriteLine("Insert Sukses");
                        }
                        else
                        {
                            Console.WriteLine("Insert Sukses");
                        }

                        crudLocalDb.pushUser(userLocalDb);
                        break;

                    case 3:
                        Console.WriteLine("+++ Menu Update +++");
                        crudLocalDb.showData();
                        Console.Write("masukan username yang ingin di update : ");
                        string oldUser = Console.ReadLine();
                        Console.Write("masukan username baru : ");
                        userLocalDb.username = Console.ReadLine();
                        Console.Write("masukan password : ");
                        userLocalDb.password = Console.ReadLine();
                        if (crudLocalDb.updateUser(userLocalDb,oldUser))
                        {
                            Console.WriteLine("Account di update");
                        }
                        else
                        {
                            Console.WriteLine("tidak ada account yang di update");
                        }
                        break;

                    case 4:
                        Console.WriteLine("+++ Menu Hapus +++");
                        crudLocalDb.showData();
                        Console.Write("masukan username yang akan di hapus : ");
                        string user = Console.ReadLine();
                        if (crudLocalDb.delUser(user))
                        {
                            Console.WriteLine("user dihapus");
                        }
                        else
                        {
                            Console.WriteLine("tidak ada user yang dihapus");
                        }
                        break;

                    default:
                        Console.WriteLine(" --- anda tidak memasukan input dengan benar ---");
                        break;

                }
            }
            else
            {
                Console.WriteLine("anda tidak memasukan input dengan benar");
            }
            

            Console.ReadLine();
            Console.Clear();
            goto mulai;
        }
    }
}
