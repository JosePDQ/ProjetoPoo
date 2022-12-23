using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using StaffSpace;

namespace ProjetoPOO
{
    class Program
    {
        static List<Equipa> equipas = new List<Equipa>();
        static List<Cavalo> cavalos = new List<Cavalo>();
        static List<Galro> galros = new List<Galro>();
        static List<Pista> pistas = new List<Pista>();
        static List<Staff> staffs = new List<Staff>();
        static List<Rider> riders = new List<Rider>();
        static List<Corrida> corridas = new List<Corrida>();
        static void Main(string[] args)
        {

            CarregarFicheiros();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1 - Equipas");
                Console.WriteLine("2 - Animais");
                Console.WriteLine("3 - Corridas");
                Console.WriteLine("4 - Pessoas");
                Console.WriteLine("0 - Fechar Programa");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    MenuEquipas();
                }
                else if (escolha == "2")
                {
                    MenuAnimais();
                }
                else if (escolha == "3")
                {
                    MenuCorridas();
                }
                else if (escolha == "4")
                {
                    MenuPessoas();
                }
                else if (escolha == "0")
                {
                    FecharPrograma();
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Prime Enter para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
        static void MenuEquipas()
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Equipas:");
                Console.WriteLine("1 - Adicione uma equipa");
                Console.WriteLine("2 - Remover uma equipa");
                Console.WriteLine("3 - Ver todas as equipas");
                Console.WriteLine("4 - Adicionar staff para as equipas");
                Console.WriteLine("5 - Adicionar rider para as equipas");
                Console.WriteLine("0 - Voltar ao main menu");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    AdicionarEquipas();
                    break;
                    
                }
                else if (escolha == "2")
                {
                    RemoverEquipas();
                    break;
    
                }
                else if (escolha == "3")
                {
                    ListarEquipas();
                    Console.ReadKey();
                    break;
                }
                else if (escolha == "4")
                {
                    AdicionarStaffParaEquipa();
                    Console.ReadKey();
                    break;
                }
                else if (escolha == "5")
                {
                    AdicionarRiderParaEquipa();
                    Console.ReadKey();
                    break;
                }
                else if (escolha == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Prime Enter para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
        static void MenuAnimais()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de animais:");
                Console.WriteLine("1 - Adicionar um cavalo");
                Console.WriteLine("2 - Adicionar um galro");
                Console.WriteLine("3 - Remover um cavalo");
                Console.WriteLine("4 - Remover um galro");
                Console.WriteLine("5 - Ver todos os animais");
                Console.WriteLine("0 - Voltar ao main menu");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                   AdicionarCavalos();
                    break;
                }
                else if (escolha == "2")
                {
                    //AdicionarGalros();
                    break;
                }
                else if (escolha == "3")
                {
                    RemoverCavalos();
                    break;
                }
                else if (escolha == "4")
                {
                    //RemoverGalros();
                    break;
                }
                else if (escolha == "5")
                {
                    ListarCavalos();
                    break;
                }
                else if (escolha == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Prime Enter para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
        static void MenuCorridas()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de corridas:");
                Console.WriteLine("1 - Adicionar uma corrida");
                Console.WriteLine("2 - Remover uma corrida");
                Console.WriteLine("3 - Ver todas as corridas");
                Console.WriteLine("0 - Voltar ao main menu");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                }
                else if (escolha == "2")
                {
                   
                }
                else if (escolha == "3")
                {
                    
                }
                else if (escolha == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Prime Enter para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
        static void MenuPessoas()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Pessoas:");
                Console.WriteLine("1 - Adicionar um rider");
                Console.WriteLine("2 - Adicionar staff");
                Console.WriteLine("3 - Remover uma pessoa");
                Console.WriteLine("4 - Ver todas as pessoas");
                Console.WriteLine("0 - Voltar ao main menu");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    AdicionarRiders();
                    break;
                }
                else if (escolha == "2")
                {
                    AdicionarStaffs();
                    break;
                }
                else if (escolha == "3")
                {
                    RemoverPessoas();
                    break;
                }
                else if (escolha == "4")
                {
                    ListarPessoas();
                    break;
                }
                else if (escolha == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Prime Enter para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
        static void ListarStaffs()
        {
            Console.Clear();
            Console.WriteLine("Membros Staff");
            foreach (Staff staff in staffs)
            {
                Console.WriteLine($"{staff.id}\t{staff.nome}\t{staff.funcao}");
            }
        }
        static void ListarRiders()
        {
            Console.WriteLine("Riders");
            foreach (Rider rider in riders)
            {
                Console.WriteLine($"{rider.id}\t{rider.nome}\t{rider.peso}KG");
            }
        }
        static void ListarPessoas()
        {
            ListarStaffs();
            ListarRiders();
            Console.WriteLine("Prima Enter para tentar novamente.");
            Console.ReadKey();
        }
        static void ListarCavalos()
        {
            Console.Clear();
            Console.WriteLine("Cavalos");
            foreach (Cavalo cavalo in cavalos)
            {
                Console.WriteLine($"{cavalo.id}\t{cavalo.nome}\t{cavalo.raca}\t{cavalo.velocidade}\t{cavalo.stamina}\t{cavalo.saude}\t{cavalo.valor}\t Rider:{cavalo.rider.nome}");
            }
            Console.ReadKey();
        }
        static void RemoverPessoas()
        {
            Console.Clear();
            Console.WriteLine("Que tipo de pessoas pretende remover? (staff, rider)");
            string remover = Console.ReadLine().ToLower();

            if (remover == "staff")
            {
                Console.Clear();
                ListarStaffs();
                Console.WriteLine("Qual id do staff que pretende remover?");
                int id = int.Parse(Console.ReadLine());
                int index = staffs.FindIndex(Staff => Staff.id == id);
                if (index == -1)
                {
                    Console.WriteLine("Staff com esse id não foi encontrada. Prima enter para continuar");
                }
                else
                {
                    staffs.RemoveAt(index);
                    Console.WriteLine("Staff removido com sucesso.Prima enter para continuar");
                }
                Console.ReadKey();

            }
            else if(remover == "rider")
            {
                Console.Clear();
                ListarRiders();
                Console.WriteLine("Qual id do rider que pretende remover?");
                int id = int.Parse(Console.ReadLine());
                int index = riders.FindIndex(Rider => Rider.id == id);
                if (index == -1)
                {
                    Console.WriteLine("Rider com esse id não foi encontrada. Prima enter para continuar");
                }
                else
                {
                    riders.RemoveAt(index);
                    Console.WriteLine("Rider removido com sucesso.Prima enter para continuar");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Dados inseridos errados. Tente outravez");
                Console.ReadKey();
                return;
            }


        }
        static void AdicionarRiders()
        {
            Console.Clear();
            Console.WriteLine("Diga o nome do rider");
            string nome = Console.ReadLine();
            Console.WriteLine("Diga o peso do rider");
            float peso = float.Parse(Console.ReadLine());


            int id;
            if (riders.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = riders[riders.Count - 1].id + 1;
            }


            Rider riderNew = new Rider(id, nome, false,peso);
            riders.Add(riderNew);

            Console.WriteLine("Rider adicionado com sucesso.Prima enter para continuar");
            Console.ReadKey();
        }
        static void AdicionarStaffs()
        {
            Console.Clear();
            Console.WriteLine("Diga o nome do staff");
            string nome = Console.ReadLine();
            Console.WriteLine("Diga a função do staff: (veterinario, ceo, treinador) ");
            string newFuncao = Console.ReadLine().ToLower();

            StaffSpace.Funcao funcao;
            if( newFuncao == "veterinario")
            {
                funcao = Funcao.Veterinario;
            }
            else if(newFuncao == "ceo")
            {
                funcao = Funcao.CEO;
            }
            else if(newFuncao == "treinador") 
            {
                funcao = Funcao.Treinador;
            }
            else
            {
                Console.WriteLine("Função inválida. O staff não foi adicionado");
                Console.ReadKey();
                return;
            }


            int id;
            if (staffs.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = staffs[staffs.Count - 1].id + 1;
            }


            Staff staffNew = new Staff(id, nome,false, funcao);
            staffs.Add(staffNew);

            Console.WriteLine("Staff adicionado com sucesso.Prima enter para continuar");
            Console.ReadKey();
        }
        static void AdicionarStaff(Staff staff, Equipa equipa)
        {
            equipa.staff.Add(staff);
            staff.trabalha = true;
        }
        static void AdicionarRider(Rider rider, Equipa equipa)
        {
            equipa.rider.Add(rider);
            rider.trabalha = true;
        }
        static void AdicionarStaffParaEquipa()
        {
            Console.Clear();
            Console.WriteLine("Lista de Staff que não tem equipa:");
            int existeStaff = 0;
            foreach (Staff staffed in staffs)
            {
                if (staffed.trabalha == false)
                {
                    existeStaff = 1;
                    Console.WriteLine($"{staffed.id}\t{staffed.nome}\t{staffed.funcao}");
                }
            }
            if(existeStaff == 0)
            {
                Console.WriteLine("Não existe staff sem equipa");
            }



            Console.WriteLine("Introduz o id do staff que pretendes adicionar a uma equipa");
            int staffId = int.Parse(Console.ReadLine());

            Staff staff = staffs.Find(s => s.id == staffId);
            if (staff == null)
            {
                Console.WriteLine("Id do staff não encontrado.");
                return;
            }

            
            foreach (Equipa equipaExisting in equipas)
            {
                Console.WriteLine($"{equipaExisting.id}\t{equipaExisting.nome}\t");
            }
                Console.WriteLine("Introduz o id da equipa a que pretendes adicionar o funcionário");
            int teamId = int.Parse(Console.ReadLine());

            

            Equipa SelectedTeam = equipas.Find(e => e.id == teamId);

            if (SelectedTeam == null)
            {
                Console.WriteLine("Id da equipa não encontrado.");
                return;
            }
            if (SelectedTeam.staff.Contains(staff))
            {
                Console.WriteLine("O membro de staff já trabalha para esta equipa");
                Console.ReadKey();
                return;
            }

            if (equipas.Any(t => t.staff.Contains(staff)))
            {
                Console.WriteLine("O membro de staff escolhido já pretence a outra equipa");
                Console.ReadKey();
                return;
            }
            Equipa equipa = equipas.Find(t => t.id == teamId);
            if (equipa == null)
            {
                Console.WriteLine("Equipa não encontrada.");
                return;
            }

            AdicionarStaff(staff,SelectedTeam);
            Console.WriteLine("O membro da staff foi adicionado com sucesso!.Prima enter para continuar");


            Console.ReadKey();
        }
        static void AdicionarRiderParaEquipa()
        {
            Console.Clear();
            Console.WriteLine("Lista de Riders que não tem equipa:");
            int existeRiders = 0;
            foreach (Rider rided in riders)
            {
                if (rided.trabalha == false)
                {
                    existeRiders = 1;
                    Console.WriteLine($"{rided.id}\t{rided.nome}\t{rided.peso}");
                }
            }
            if (existeRiders == 0)
            {
                Console.WriteLine("Não existe riders sem equipa");
            
            }
            Console.WriteLine();
            Console.WriteLine("Introduz o id do rider que pretendes adicionar a uma equipa");
            int riderId = int.Parse(Console.ReadLine());

            Rider rider = riders.Find(s => s.id == riderId);
            if (rider == null)
            {
                Console.WriteLine("Id do rider não encontrado.");
                return;
            }


            foreach (Equipa equipaExisting in equipas)
            {
                Console.WriteLine($"{equipaExisting.id}\t{equipaExisting.nome}\t");
            }
            Console.WriteLine("Introduz o id da equipa a que pretendes adicionar o funcionário");
            int teamId = int.Parse(Console.ReadLine());

            Equipa SelectedTeam = equipas.Find(e => e.id == teamId);
            int checkTeam = 0;
            foreach (Equipa equipaCheck in equipas)
            {
                foreach (Rider riderCheck in equipaCheck.rider)
                {
                    if(riderCheck.id == riderId)
                    {
                        Console.WriteLine("O rider já tem equipa");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            Equipa equipa = equipas.Find(t => t.id == teamId);
            if (equipa == null)
            {
                Console.WriteLine("Equipa não encontrada.");
                return;
            }

            AdicionarRider(rider,SelectedTeam);
            Console.WriteLine("O rider foi adicionado com sucesso!.Prima enter para continuar");

           

            Console.ReadKey();
        }
        static void AdicionarCavalos()
        {
            Console.Clear();
            Console.WriteLine("Diga o nome do cavalo");
            string nome = Console.ReadLine();
            Console.WriteLine("Diga a raça do cavalo");
            string raca = Console.ReadLine();
            Console.WriteLine("Diga a velocidade registada do cavalo");
            int velocidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga a stamina registada do cavalo");
            int stamina = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga o valor registado do cavalo");
            float valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Lista de Riders com equipa:");
            int existeRiders = 0;
            foreach (Rider rided in riders)
            {
               
                if (rided.trabalha == true)
                {
                   existeRiders = 1;
                   Console.WriteLine($"{rided.id}\t{rided.nome}\t{rided.peso}");
                }
                
            }
            if (existeRiders == 0)
            {
                Console.WriteLine("Não existe riders com equipa");
                Console.ReadKey();
                return;

            }
            Console.WriteLine();
            Console.WriteLine("Diga o id do rider");
            int riderId = int.Parse(Console.ReadLine());
            Rider rider = riders.Find(s => s.id == riderId);

            if (rider == null)
            {
                Console.WriteLine("Não existe um rider com esse id");
                Console.ReadKey();
                return;
            }
            int temCavalo = 0;
            foreach (Cavalo cavaloFinder in cavalos)
            {
                if (cavaloFinder.rider.id == riderId)
                {
                    temCavalo++;
                }
            }
            
            if (temCavalo > 0)
            {
                Console.WriteLine("O rider selecionado já tem um cavalo e não pode ser associado a outro");
                Console.ReadKey();
                return;
            }
            


            int id;
             if (cavalos.Count == 0)
             {
                 id = 1;
             }
             else
             {
                 id = cavalos[cavalos.Count - 1].id + 1;
             }

            Cavalo cavalo = new Cavalo(id, nome, raca, velocidade, stamina, true, valor, rider);

            cavalos.Add(cavalo);

            Console.WriteLine("Cavalo adicionado com sucesso.Prima enter para continuar");
            Console.ReadKey();
        }
        static void RemoverCavalos()
        {
            ListarCavalos();
            Console.WriteLine("Diga o id do cavalo que pretende eliminar");
            int id = int.Parse(Console.ReadLine());
            Cavalo SelectedCavalo = cavalos.Find(e => e.id == id);
            int index = cavalos.FindIndex(cavalo => cavalo.id == id);
            if (index == -1)
            {
                Console.WriteLine("Cavalo não foi encontrado. Prima enter para continuar");
            }
            else
            {
                cavalos.RemoveAt(index);
                Console.WriteLine("Equipa removida com sucesso.Prima enter para continuar");
            }
            Console.ReadKey();
        }
        static void RemoverEquipas()
        {
            ListarEquipas();
            Console.WriteLine("Diga o id da equipa que pretende eliminar");
            int id = int.Parse(Console.ReadLine());
            Equipa SelectedTeam = equipas.Find(e => e.id == id);
            int index = equipas.FindIndex(Equipa => Equipa.id == id);
            if( index == -1)
            {
                Console.WriteLine("Equipa não foi encontrada. Prima enter para continuar");
            }
            else
            {
                foreach (Staff staff in SelectedTeam.staff)
                {
                    staff.trabalha = false;
                    
                }
                foreach (Rider rider in SelectedTeam.rider)
                {
                    rider.trabalha = false;

                }
                equipas.RemoveAt(index);
                Console.WriteLine("Equipa removida com sucesso.Prima enter para continuar");
            }
            Console.ReadKey();
        }
        static void ListarEquipas()
        {
            Console.Clear();
            foreach (Equipa equipa in equipas)
            {
                Console.WriteLine($"Equipa id: {equipa.id}");
                Console.WriteLine($"Nome de equipa: {equipa.nome}");
                Console.WriteLine("Staff: ");

                foreach (Staff membro in equipa.staff)
                {
                    Console.WriteLine($" - {membro.nome} - ({membro.funcao})");
                }
                Console.WriteLine("Riders:");
                foreach (Rider membro in equipa.rider)
                {
                    Console.WriteLine($" - {membro.nome} - {membro.peso}KG");
                }
                Console.WriteLine();Console.WriteLine();
            }
        }
        static void AdicionarEquipas()
        {
            Console.Clear();
            Console.WriteLine("Escolha o nome para a equipa");
            string nome = Console.ReadLine();

            int id;
            if (equipas.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = equipas[equipas.Count - 1].id + 1;
            }
            

            Equipa equipa = new Equipa()
            {
                id = id,
                nome = nome,
                staff = new List<Staff>(),
                rider = new List<Rider>(),
                cavalos = new List<Cavalo>(),
                galros = new List<Galro>(),
            };

            equipas.Add(equipa);

            Console.WriteLine("Equipa criada com sucesso.Prima enter para continuar");
            Console.ReadKey();
        }
        static void CarregarFicheiros()
        {

            string equipasJson = File.ReadAllText("equipas.json");
            equipas = JsonConvert.DeserializeObject<List<Equipa>>(equipasJson);

            string cavalosJson = File.ReadAllText("cavalos.json");
            cavalos = JsonConvert.DeserializeObject<List<Cavalo>>(cavalosJson);

            string galrosJson = File.ReadAllText("galros.json");
            galros = JsonConvert.DeserializeObject<List<Galro>>(galrosJson);

            string pistasJson = File.ReadAllText("pistas.json");
            pistas = JsonConvert.DeserializeObject<List<Pista>>(pistasJson);

            string staffsJson = File.ReadAllText("staffs.json");
            staffs = JsonConvert.DeserializeObject<List<Staff>>(staffsJson);

            string ridersJson = File.ReadAllText("riders.json");
            riders = JsonConvert.DeserializeObject<List<Rider>>(ridersJson);

            string corridasJson = File.ReadAllText("corridas.json");
            corridas = JsonConvert.DeserializeObject<List<Corrida>>(corridasJson);




        }
        static void SalvarFicheiros()
        {
            string equipasJson = JsonConvert.SerializeObject(equipas);
            File.WriteAllText("equipas.json", equipasJson);

            string cavalosJson = JsonConvert.SerializeObject(cavalos);
            File.WriteAllText("cavalos.json", cavalosJson);

            string galrosJson = JsonConvert.SerializeObject(galros);
            File.WriteAllText("galros.json", galrosJson);

            string pistasJson = JsonConvert.SerializeObject(pistas);
            File.WriteAllText("pistas.json", pistasJson);

            string staffsJson = JsonConvert.SerializeObject(staffs);
            File.WriteAllText("staffs.json", staffsJson);

            string ridersJson = JsonConvert.SerializeObject(riders);
            File.WriteAllText("riders.json", ridersJson);

            string corridasJson = JsonConvert.SerializeObject(corridas);
            File.WriteAllText("corridas.json", corridasJson);

        }
        static void FecharPrograma()
        {
            SalvarFicheiros();
            Environment.Exit(0);
        }

     
    }
}