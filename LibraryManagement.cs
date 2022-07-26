using System.Data;
using ConsoleTables;
class LibraryManagement : MenuProgram
{

    public List<Manga> mangas;
    public LibraryManagement()
    {
        mangas = new List<Manga>()
        {
            new Manga("Dragonball Super", "Akira Toriyama","Action", 25000, 110),
            new Manga("One Punch Man", "One", "Manga", 20000, 120),
            new Manga("Doraemon", "Fujiko","Funny", 15000, 150),
            new Manga("One Piece", "Eiichiro Oda","Comedy", 25000, 110),
        };
    }
    protected override void PrintMenu()
    {
        Console.WriteLine("\n+------------LibraryManagement--------------+");
        Console.WriteLine("| 1.      Add Manga in Library              |");
        Console.WriteLine("| 2.      Edit Manga in Library             |");
        Console.WriteLine("| 3.      Delete Manga in Library           |");
        Console.WriteLine("| 4.      Find Manga by ID                  |");
        Console.WriteLine("| 5.      Sort Managa                       |");
        Console.WriteLine("| 6.      Print All Manga                   |");
        Console.WriteLine("| 7.      Backup Data                       |");
        Console.WriteLine("| 0.      Exit Program                      |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine();

    }

    protected override void DoSomething(int Option)
    {
        switch (Option)
        {
            case 1:
                Console.WriteLine("\t[1] Add Manga in Program!");
                AddManga();
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            case 2:
                Console.WriteLine("\t[2] Edit Manga in Program!");
                if (mangas.Count > 0)
                {
                    EditManga();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t(!) No manga to Edit in Program");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            case 3:
                Console.WriteLine("\t[3] Delete Manga in Program!");
                if (mangas.Count > 0)
                {
                    DeleteManga();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t(!) No manga to Delete in Program");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            case 4:
                Console.WriteLine("\t[4] Find Manga in Program!");
                if (mangas.Count > 0)
                {
                    FindManga();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t(!) No manga to Find in Program");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            case 5:
                Console.WriteLine("\t[5] Sort Manga in Program!");
                SortManga();
                Console.Clear();
                break;
            case 6:
                Console.WriteLine("\t[6] List Manga in Program!");
                if (mangas.Count > 0)
                {
                    PrintManga();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t(!) No manga in Program");
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            case 7:
                Console.WriteLine("\t[7] Backup Manga in Text!");
                BackUp();
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            case 0:
                Console.WriteLine();
                Console.WriteLine("\t\t(!)Good bye see you again!");
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Invalid Option! Please Choose Option Again!!");
                Console.WriteLine("Press and key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }

    private void BackUp()
    {
        string filename = "Manga.txt";
        
        StreamWriter s;
        s = File.CreateText(filename);
        foreach (Manga item in mangas)
        {
           s.WriteLine(item.Id + ";" + item.Name + ";" + item.Author + item.Price + ";" + item.Page + ";" + item.Datetime + ";"); 
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t(!) Back up successfully! ");
        Console.WriteLine();
        s.Close();
        
    }

    private void PrintManga()
    {
        Console.WriteLine();
        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        Console.WriteLine("|{0,2}  | {1,20} | {2,20} | {3,15} | {4,15} | {5, 15} | {6,30} |", " ID", "Name Manga", "Author", "Category", "Price", "Page Number", "DateTime");
        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        foreach (Manga mg in mangas)
        {
            Console.WriteLine(mg);
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        }
        Console.WriteLine();

    }

    private void SortManga()
    {
        Console.Clear();
        Run();

        void PrintMenu()
        {
            {
                Console.WriteLine("\n+------------LibraryManagement--------------+");
                Console.WriteLine("| 1.      Sort Name Manga                   |");
                Console.WriteLine("| 2.      Sort Price Managa                 |");
                Console.WriteLine("| 3.      Sort Page Managa                  |");
                Console.WriteLine("| 0.      Back to Library                   |");
                Console.WriteLine("+-------------------------------------------+");
                Console.WriteLine();
            }
        }
        int ChooseOption()
        {
            Console.Write("Enter Your Option: ");
            int Option = Convert.ToInt32(Console.ReadLine());
            return Option;
        }
        void DoSomething(int Option)
        {
            switch (Option)
            {
                case 1:
                    Console.WriteLine("\t[1] Sort Name Manga in Program!");
                    SortName();
                    Console.WriteLine("Press and key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("\t[2] Sort Price Manga in Program!");
                    SortPrice();
                    Console.WriteLine("Press and key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("\t[3] Sort Page Manga in Program!");
                    SortPage();
                    Console.WriteLine("Press and key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("\t[0] Back to Library!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid Option! Please Choose Option Again!!");
                    Console.WriteLine("Press and key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int Option = ChooseOption();

                DoSomething(Option);

                if (Option == 0) running = false;
            }
        }
    }

    private void SortPage()
    {
        mangas.Sort(delegate (Manga mg1, Manga mg2)
        {
            return mg1.Page.CompareTo(mg2.Page);
        });
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t (!) Sort Name Successfully !!!!");
        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        Console.WriteLine("|{0,2}  | {1,20} | {2,20} | {3,15} | {4,15} | {5, 15} | {6,30} |", " ID", "Name Manga", "Author", "Category", "Price", "Page Number", "DateTime");
        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        foreach (Manga mg in mangas)
        {
            Console.WriteLine(mg);
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        }

    }

    private void SortPrice()
    {
        mangas.Sort(delegate (Manga mg1, Manga mg2)
        {
            return mg1.Price.CompareTo(mg2.Price);
        });
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t (!) Sort Name Successfully !!!!");
        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        Console.WriteLine("|{0,2}  | {1,20} | {2,20} | {3,15} | {4,15} | {5, 15} | {6,30} |", " ID", "Name Manga", "Author", "Category", "Price", "Page Number", "DateTime");
        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        foreach (Manga mg in mangas)
        {
            Console.WriteLine(mg);
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        }
    }

    private void SortName()
    {

        mangas.Sort(delegate (Manga mg1, Manga mg2)
        {
            return mg1.Name.CompareTo(mg2.Name);
        });
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t (!) Sort Name Successfully !!!!");
        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        Console.WriteLine("|{0,2}  | {1,20} | {2,20} | {3,15} | {4,15} | {5, 15} | {6,30} |", " ID", "Name Manga", "Author", "Category", "Price", "Page Number", "DateTime");
        Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        foreach (Manga mg in mangas)
        {
            Console.WriteLine(mg);
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        }
    }

    private void FindManga()
    {
        Console.Write("\t\t(?) Enter id want to find: ");
        int id = Convert.ToInt32(Console.ReadLine());

        int pos = FindById(id);
        Console.WriteLine();
        if (pos == -1)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not Found Manga with ID = {id}");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
            Console.WriteLine("|{0,2}  | {1,20} | {2,20} | {3,15} | {4,15} | {5, 15} | {6,30} |", " ID", "Name Manga", "Author", "Category", "Price", "Page Number", "DateTime");
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
            Console.WriteLine(mangas[pos]);
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
        }
        Console.WriteLine();


    }

    private void DeleteManga()
    {
        Console.Write("\t\t(?) Enter id want to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        int pos = FindById(id);
        Console.WriteLine();
        if (pos != -1)
        {
            mangas.RemoveAt(pos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t (!) Delete successfully!!!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\t (!) Delete not successfully with Manga Id {id}!!!");
            Console.ResetColor();
        }
    }

    private void EditManga()
    {
        Console.Write("\t\t(?) Enter id want to Edit: ");
        int id = Convert.ToInt32(Console.ReadLine());
        int pos = FindById(id);
        Console.WriteLine();
        if (pos != -1)
        {
            Console.WriteLine();
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
            Console.WriteLine("|{0,2}  | {1,20} | {2,20} | {3,15} | {4,15} | {5, 15} | {6,30} |", " ID", "Name Manga", "Author", "Category", "Price", "Page Number", "DateTime");
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
            Console.WriteLine(mangas[pos]);
            Console.WriteLine("+-----+----------------------+----------------------+-----------------+-----------------+-----------------+--------------------------------+");
            Console.WriteLine();

            Console.Write("\t\t(?) Enter Name Manga want to edit:  ");
            string name = Console.ReadLine();
            Console.Write("\t\t(?) Enter Author Manga want to edit:  ");
            string author = Console.ReadLine();
            Console.Write("\t\t(?) Enter Category Manga want to edit:  ");
            string category = Console.ReadLine();
            Console.Write("\t\t(?) Enter Price Manga want to edit:  ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t\t(?) Enter Page Manga want to edit:  ");
            int page = Convert.ToInt32(Console.ReadLine());

            mangas[pos].Name = name;
            mangas[pos].Author = author;
            mangas[pos].Category = category;
            mangas[pos].Price = price;
            mangas[pos].Page = page;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Update success fully");
            Console.ResetColor();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Not found manga with ID to Edit:  {id} !!!!");
            Console.ResetColor();
        }

    }

    private void AddManga()
    {
        Console.Write("\t\t(?) Enter Name Manga:  ");
        string name = Console.ReadLine();
        Console.Write("\t\t(?) Enter Author Manga:  ");
        string author = Console.ReadLine();
        Console.Write("\t\t(?) Enter Category Manga:  ");
        string category = Console.ReadLine();
        Console.Write("\t\t(?) Enter Price Manga:  ");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.Write("\t\t(?) Enter Page Manga:  ");
        int page = Convert.ToInt32(Console.ReadLine());


        Manga mg = new Manga(name, author, category, price, page);
        mg.Size++;
        mangas.Add(mg);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t(!) Add Manga successfully!!");
        Console.ResetColor();
    }

    public int FindById(int id)
    {
        for (int i = 0; i < mangas.Count; i++)
        {
            if (mangas[i].Id == id)
            {
                return i;
            }
        }
        return -1;
    }
}