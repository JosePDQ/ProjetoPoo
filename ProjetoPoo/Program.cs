using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using StaffSpace;
using CorridasSpace;
using EventosSpace;
using System.Threading;

namespace ProjetoPOO
{
    class Program
    {
        static List<Equipa> equipas = new List<Equipa>();
        static List<Cavalo> cavalos = new List<Cavalo>();
        static List<Pista> pistas = new List<Pista>();
        static List<Staff> staffs = new List<Staff>();
        static List<Rider> riders = new List<Rider>();
        static List<Corrida> corridas = new List<Corrida>();
        static List<Evento> eventos = new List<Evento>();

        static Game games = new Game();
        static void Main(string[] args)
        {
          
            CarregarFicheiros();
            
            while (true)
            {

                Console.Clear();

                Console.WriteLine("Main Menu:");
                Console.WriteLine("Dia Atual: " + games.DiaAtual.dia + "/" + games.DiaAtual.mes + "/" + games.DiaAtual.ano);
                Console.WriteLine("1 - Avançar 1 dia");
                Console.WriteLine("2 - Adicionar Evento");
                Console.WriteLine("3 - Listar Eventos");
                Console.WriteLine("4 - Adicionar Corridas");
                Console.WriteLine("5 - Listar Corridas");
                Console.WriteLine("6 - Comprar Cavalos");
                Console.WriteLine("7 - Admin Menu");
                Console.WriteLine("0 - Fechar Programa");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    AvancarDia();
                    
                }
                else if (escolha == "2")
                {
                    AdicionarEventos();
                }
                else if (escolha == "3")
                {
                    ListarEventos();
                }
                else if (escolha == "4")
                {
                    AdicionarCorridas();
                }
                else if (escolha == "5")
                {
                    ListarCorridas();
                }
                else if (escolha == "6")
                {
                    CompraCavalos();
                }
                else if (escolha == "7")
                {
                    MenuAdmin();
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
        static void MenuAdmin()
        {

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1 - Equipas");
                Console.WriteLine("2 - Animais");
                Console.WriteLine("3 - Corridas");
                Console.WriteLine("4 - Pessoas");
                Console.WriteLine("5 - Pistas");
                Console.WriteLine("0 - Voltar atrás");
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
                else if (escolha == "5")
                {
                    MenuPistas();
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
                    //RemoverEquipas();
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
                Console.WriteLine("2 - Remover um cavalo");
                Console.WriteLine("3 - Ver todos os animais");
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
                    RemoverCavalos();
                    break;
                }
                else if (escolha == "3")
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
        static void MenuPistas()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Pessoas:");
                Console.WriteLine("1 - Adicionar uma pista");
                Console.WriteLine("2 - Editar uma pista");
                Console.WriteLine("3 - Ver todas as pistas");
                Console.WriteLine("0 - Voltar ao main menu");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    AdicionarPistas();
                    break;
                }
                else if (escolha == "2")
                {
                    EditarPistas();
                    break;
                }
                else if (escolha == "3")
                {
                    ListarPistas();
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
            var equipaID = 0;
            cavalos.Add(cavalo);
            foreach (Equipa equipa in equipas)
            {
                foreach (Rider membro in equipa.rider)
                {
                    if (membro.id == riderId)
                    {
                        equipaID = equipa.id;
                        break;
                    }
                }
            }

            foreach (Equipa equipa in equipas)
            {
                Equipa equipaCavalo = equipas.Find(e => e.id == equipaID);
                if (equipaCavalo != null)
                {
                    equipaCavalo.cavalos.Add(cavalo);
                    break;
                }
            }

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
                Console.WriteLine("Cavalo removido com sucesso.Prima enter para continuar");
            }
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
            return;
        }
       /*static void RemoverEquipas()
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
        }*/
        static void ListarEquipas()
        {
            Console.Clear();
            foreach (Equipa equipa in equipas)
            {
                Console.WriteLine($"Equipa id: {equipa.id}");
                Console.WriteLine($"Nome de equipa: {equipa.nome}");
                Console.WriteLine($"Dinheiro da equipa: {equipa.money}");
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
                foreach (Cavalo cavalo in equipa.cavalos)
                {
                    Console.WriteLine($" - Cavalo: {cavalo.nome}");
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
                money = 10000
            };

            equipas.Add(equipa);

            Console.WriteLine("Equipa criada com sucesso.Prima enter para continuar");
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
            if (existeStaff == 0)
            {
                Console.WriteLine("Não existe staff sem equipa");
                Console.ReadKey();
                return;
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
            foreach (Equipa equipaCheck in equipas)
            {
                foreach (Staff staffCheck in equipaCheck.staff)
                {
                    if (staffCheck.id == staffId)
                    {
                        Console.WriteLine("O staff já tem equipa");
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

            AdicionarStaff(staff, SelectedTeam);
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
                Console.ReadKey();
                return;

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
            foreach (Equipa equipaCheck in equipas)
            {
                foreach (Rider riderCheck in equipaCheck.rider)
                {
                    if (riderCheck.id == riderId)
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

            AdicionarRider(rider, SelectedTeam);
            Console.WriteLine("O rider foi adicionado com sucesso!.Prima enter para continuar");



            Console.ReadKey();
        }
        static void AdicionarPistas()
        {
            Console.Clear();
            Console.WriteLine("Diga o nome da pista");
            string nome = Console.ReadLine();
            Console.WriteLine("Diga o comprimento da pista");
            float comprimento = float.Parse(Console.ReadLine());


            int id;
            if (pistas.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = pistas[pistas.Count - 1].id + 1;
            }


            Pista NewPista = new Pista(id, nome, comprimento);
            pistas.Add(NewPista);

            Console.WriteLine("Pista adicionada com sucesso.Prima enter para continuar");
            Console.ReadKey();
        }
        static void EditarPistas()
        {
            ListarPistas();
            Console.Write("Diga o id da pista");
            int id = int.Parse(Console.ReadLine());

            Pista pista = pistas.Find(t => t.id == id);
            if (pista == null)
            {
                Console.WriteLine("Pista com esse id não existe.");
                return;
            }

            Console.Write("Diga o nome da pista ");
            pista.nome = Console.ReadLine();

            Console.Write("Diga o novo comprimento da pista: ");
            pista.comprimento = float.Parse(Console.ReadLine());

            Console.WriteLine("Pista editada.");
        }
        static void ListarPistas()
        {
            Console.Clear();
            Console.WriteLine("Pistas");
            foreach (Pista pista in pistas)
            {
                Console.WriteLine($"{pista.id}\t{pista.nome}\t{pista.comprimento}m");
            }
            Console.ReadKey();
        }
        /*static void RemoverPistas()
      {
          ListarPistas();
          Console.WriteLine("Diga o id do cavalo que pretende eliminar");
          int id = int.Parse(Console.ReadLine());
          Pista SelectedPista = pistas.Find(e => e.id == id);
          int index = pistas.FindIndex(pista => pista.id == id);
          if (index == -1)
          {
              Console.WriteLine("Cavalo não foi encontrado. Prima enter para continuar");
          }
          else
          {
              pistas.RemoveAt(index);
              Console.WriteLine("Equipa removida com sucesso.Prima enter para continuar");
          }
          Console.ReadKey();
      }*/
        public static Cavalo GetHorseById(List<Cavalo> cavalos,int id)
        {
            foreach( Cavalo cavalo in cavalos)
            {
                if(cavalo.id == id)
                {
                    return cavalo;
                }
         
            }
            return null;
        }
        static void AdicionarCorridas()
        {
            Console.Clear();

            Console.WriteLine("Escolhe o tipo de corrida (Obstaculos,Sprint,Maratona):");
            string tipoCorrida = Console.ReadLine().ToLower();
            CorridasSpace.TipoCorrida tipo;
            if (tipoCorrida == "obstaculos")
            {
                tipo = TipoCorrida.Obstáculos;
            }
            else if (tipoCorrida == "sprint")
            {
                tipo = TipoCorrida.Sprint;
            }
            else if (tipoCorrida == "maratona")
            {
                tipo = TipoCorrida.Maratona;
            }
            else
            {
                Console.WriteLine("Tipo inválido. A corrida não foi adicionada");
                Console.ReadKey();
                return;
            }
            ListarPistas();
            Console.WriteLine("Diga a pista da corrida");
            int trackId = int.Parse(Console.ReadLine());

            var pista = pistas.FirstOrDefault(t=> t.id == trackId);
            if (pista == null)
            {
                Console.WriteLine("Pista não existe");
               
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Diga a data da corrida (dd-mm-yyyy): ");
            int dia = int.Parse(Console.ReadLine());
            int mes = int.Parse(Console.ReadLine());
            int ano = int.Parse(Console.ReadLine());
            Calendario diaCorrida = new Calendario { dia = dia, mes = mes, ano = ano };
            if(diaCorrida.dia > DateTime.DaysInMonth(diaCorrida.dia, diaCorrida.mes))
            {
                Console.WriteLine("Data inválida");
                Console.ReadKey();
                return;
            }
            ListarCavalos();
            
            Console.WriteLine("Diga o id dos cavalos para a corrida");
            List<Cavalo> corridaCavalos = new List<Cavalo>();
            while (true)
            {
                Console.Write("Diga o id do cavalo (0 para acabar)");
                int horseId= int.Parse(Console.ReadLine());
                if (horseId == 0)
                {
                    break;
                }
                Cavalo cavalo = GetHorseById(cavalos,horseId);

                if (cavalo == null)
                {
                    Console.WriteLine("Não tem cavalo com esse id");
                    continue;
                }
                corridaCavalos.Add(cavalo);

                if(corridaCavalos.Count == 0)
                {
                    Console.WriteLine("Tens que adicionar pelo menos 1 cavalo á corrida");
                    return;
                }
            }

            Corrida existingRace = corridas.Find(r => r.data.dia == diaCorrida.dia && r.data.mes == diaCorrida.mes && r.data.ano == diaCorrida.ano);
            if (existingRace != null)
            {
                Console.WriteLine("Já tem corrida para esse dia, marca para outro");
                Console.ReadKey();
                return;
            }
            else
            {
                Corrida newCorrida = new Corrida(diaCorrida,pista, corridaCavalos, tipo);
                corridas.Add(newCorrida);
                Console.WriteLine("Evento adicionado com sucesso!");
            }
            Console.ReadKey();
        }
        static void ListarCorridas()
        {
            Console.Clear();
            foreach (Corrida corrida in corridas)
            {
                Console.WriteLine($"Data: {corrida.data.dia}/{corrida.data.mes}/{corrida.data.ano}");
                Console.WriteLine($"Nome de equipa: {corrida.pista.nome}");
                Console.WriteLine($"Tipo: {corrida.tipo}");

                foreach (Cavalo cavalo in corrida.participantes)
                {
                    Console.WriteLine($" cavalo :{cavalo.nome} - rider:({cavalo.rider.nome})");
                }
               
                Console.WriteLine(); Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void AdicionarEventos()
        {
            Console.Clear();
            Console.WriteLine("Qual é o id da tua equipa");
            int teamId = int.Parse(Console.ReadLine());

            Equipa equipa = equipas.FirstOrDefault(t => t.id == teamId);
            if (equipa == null)
            {
                Console.WriteLine("Não tem equipa com esse id");
                Console.ReadKey();
                return;
            }

           
            Console.WriteLine("Escolhe o tipo de evento (Treino,Descanço,Media):");
            string tipoEvento = Console.ReadLine().ToLower();
            EventosSpace.TipoEvento tipo;
            if (tipoEvento == "treino")
            {
                tipo = TipoEvento.Treino;
            }
            else if (tipoEvento == "descanço")
            {
                tipo = TipoEvento.Descanço;
            }
            else if (tipoEvento == "media")
            {
                tipo = TipoEvento.Media;
            }
            else
            {
                Console.WriteLine("Tipo inválido. O evento não foi adicionado");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Diga a data do evento (dd-mm-yyyy): ");
            int dia = int.Parse(Console.ReadLine());
            int mes = int.Parse(Console.ReadLine());
            int ano = int.Parse(Console.ReadLine());
            Calendario diaEvento = new Calendario { dia = dia, mes = mes , ano = ano};

            Evento isEventExist = eventos.FirstOrDefault(e => e.teamId == teamId && e.data.dia == diaEvento.dia && e.data.mes == diaEvento.mes && e.data.ano == diaEvento.ano);
            if (isEventExist != null)
            {
                Console.WriteLine("A equipa já tem evento para esse dia, marca para outro");
                Console.ReadKey();
                return;
            }
            else
            {
                Evento newEvent = new Evento(teamId, tipo, teamId, diaEvento);
                eventos.Add(newEvent);
                Console.WriteLine("Evento adicionado com sucesso!");
            }
            Console.ReadKey();
        }
        static void ListarEventos()
        {
            Console.Clear();
            Console.WriteLine("Eventos");
            foreach (Evento evento in eventos)
            {
                Console.WriteLine($"Tipo:{evento.tipoEvento}\tEquipa:{evento.teamId}\tDia:{evento.data.dia}/{evento.data.mes}/{evento.data.ano}");
            }
            Console.ReadKey();
        }


        static void VerificaEvento()
        {
            foreach (Evento evento in eventos) { 
                if (games.DiaAtual.dia == evento.data.dia && games.DiaAtual.mes == evento.data.mes && games.DiaAtual.ano == evento.data.ano)
                {
                    if (evento.tipoEvento == TipoEvento.Descanço)
                    {
                        Descanco(evento);
                    }
                    else if (evento.tipoEvento == TipoEvento.Treino)
                    {
                        Treino(evento);
                    }
                    else if (evento.tipoEvento == TipoEvento.Media)
                    {
                        Media(evento);
                    }
                }
            }
        }


        
        static void Descanco(Evento evento)
        {
            Equipa equi = equipas.Find(s => s.id == evento.teamId);
            foreach (Cavalo c in equi.cavalos)
            {
                if(c.stamina < 91) { 
                    c.stamina += 10;
                    cavalos.Find(r => r.id == c.id).stamina += 20;
                }

            }
        }
        static void Treino(Evento evento)
        {
            Equipa equi = equipas.Find(s => s.id == evento.teamId);
            if (equi.money >= 1000)
            {
                equi.money -= 1000;
                foreach (Cavalo c in equi.cavalos)
                {
                    c.velocidade += 2;
                    cavalos.Find(r => r.id == c.id).velocidade += 2;
                    cavalos.Find(r => r.id == c.id).stamina -= 10;


                }
            }
            else Console.WriteLine("Saldo Insuficiente");
           

        }
        static void Media(Evento evento)
        {
            Equipa equi = equipas.Find(s => s.id == evento.teamId);
            if (equi.money >= 1000)
            {
                equi.money -= 1000;
                foreach (Cavalo c in equi.cavalos)
                {
                    c.valor += 10000;
                    cavalos.Find(r => r.id == c.id).valor += 10000;
                    cavalos.Find(r => r.id == c.id).stamina -= 5;


                }
            }
            else Console.WriteLine("Saldo Insuficiente");
        }

        static void AvancarDia()
        {
            games.DiaAtual.dia++;
            if (games.DiaAtual.dia > DateTime.DaysInMonth(games.DiaAtual.ano, games.DiaAtual.mes))
            {
                games.DiaAtual.dia = 1;
                games.DiaAtual.mes++;
                if (games.DiaAtual.mes > 12)
                {
                    games.DiaAtual.mes = 1;
                    games.DiaAtual.ano++;
                }
            }
            VerificaEvento();
            VerificaCorrida();
            
        }

        static void Corrida()
        {
            double saveHigherScore = 0;
            int saveHorseId = 0;
            Random rnd = new Random();


            List<int> horsePositions = new List<int>();
            for (int i = 0; i < corridas[0].participantes.Count; i++)
            {
                horsePositions.Add(0);
            }

            for (int time = 0; time < 20; time++)
            {
                for (int i = 0; i < corridas[0].participantes.Count; i++)
                {

                    horsePositions[i] += corridas[0].participantes[i].velocidade;

                    Console.Clear();
                    for (int j = 0; j < horsePositions.Count; j++)
                    {
                        int previousPosition = horsePositions[j];
                        if (horsePositions[j] >= 0 && horsePositions[j] < Console.BufferWidth)
                        {
                            Console.SetCursorPosition(previousPosition, j);
                            Console.Write(" ");
                            horsePositions[j] += corridas[0].participantes[j].velocidade;
                        }
                        int position = horsePositions[j] % Console.BufferWidth;
                        Console.SetCursorPosition(position, j);
                        Console.Write(corridas[0].participantes[j].nome);
                    }

                    int random = rnd.Next(1, 50);
                    if (corridas[0].tipo == TipoCorrida.Maratona)
                    {
                        double newScore = (corridas[0].participantes[i].stamina / 100 * corridas[0].pista.comprimento * 0.4) + (corridas[0].participantes[i].velocidade * 0.8) + (random * 0.2) - (corridas[0].participantes[i].rider.peso * 0.1);
                        if (newScore > saveHigherScore)
                        {
                            saveHigherScore = newScore;
                            saveHorseId = corridas[0].participantes[i].id;
                        }
                    }
                    else if (corridas[0].tipo == TipoCorrida.Obstáculos)
                    {
                        double newScore = (corridas[0].participantes[i].stamina / 100 * corridas[0].pista.comprimento * 0.25) + (corridas[0].participantes[i].velocidade * 1.5) + (random * 0.2) - (corridas[0].participantes[i].rider.peso * 0.1);
                        if (newScore > saveHigherScore)
                        {
                            saveHigherScore = newScore;
                            saveHorseId = corridas[0].participantes[i].id;
                        }
                    }
                    else if (corridas[0].tipo == TipoCorrida.Sprint)
                    {
                        double newScore = (corridas[0].participantes[i].stamina / 100 * corridas[0].pista.comprimento * 0.1) + (corridas[0].participantes[i].velocidade * 2) + (random * 0.2) - (corridas[0].participantes[i].rider.peso * 0.1);
                        if (newScore > saveHigherScore)
                        {
                            saveHigherScore = newScore;
                            saveHorseId = corridas[0].participantes[i].id;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                    Thread.Sleep(300);
                }
            }
            Cavalo winner = cavalos.Find(r => r.id == saveHorseId);
            foreach (Equipa equipa in equipas)
            {
                foreach (Cavalo cavalo in equipa.cavalos)
                {
                    if (cavalo.id == winner.id)
                    {
                        Equipa WinnerTeam = equipa;
                        WinnerTeam.money += 25000;
                    }
                }
            }

            // Find the winner and print the winner name

            Console.Clear();
            Console.WriteLine("O cavalo vencedor da corrida é " + winner.nome);
            Console.ReadKey();
            return;
        }
        static void CompraCavalos()
        {
            Console.Clear();
            Console.WriteLine("Qual é o id da tua equipa");
            int teamId = int.Parse(Console.ReadLine());

            Equipa equipa = equipas.FirstOrDefault(t => t.id == teamId);
            if (equipa == null)
            {
                Console.WriteLine("Não tem equipa com esse id");
                Console.ReadKey();
                return;
            }

            foreach (Equipa equipaList in equipas) {
                if (equipaList.id == teamId)
                {
                    foreach (Rider rider in equipaList.rider)
                    {
                        Console.WriteLine($"{rider.id}\t{rider.nome}\t{rider.peso}KG");
                    }
                }
            }
            Console.WriteLine("Qual é o id do rider que pretende atribuir o cavalo");
            int riderID = int.Parse(Console.ReadLine());
            Rider newRider = riders.FirstOrDefault(t => t.id == riderID);

            ListarCavalos();
            
            Console.WriteLine("Qual é o id do cavalo que pretende comprar");
            int compraID = int.Parse(Console.ReadLine());

            Cavalo cavalo = cavalos.FirstOrDefault(t => t.id == compraID);
            if (cavalo == null)
            {
                Console.WriteLine("Não tem cavalo com esse id");
                Console.ReadKey();
                return;
            }
            else
            {
                if (equipa.money >= cavalo.valor)
                {
                    Cavalo horseToRemove = null;
                    cavalo.rider = newRider;
                    int oldTeamID = -1;
                    foreach(Equipa horseTeam in equipas)
                    {
                        horseToRemove = horseTeam.cavalos.Find(h => h.id == cavalo.id);
                        foreach (Cavalo allHorses in horseTeam.cavalos) 
                        {
                            if (allHorses.id == compraID)
                            {
                                oldTeamID = horseTeam.id;
                                break;
                            }
                        }
                    }
                   
                    if(oldTeamID != -1)
                    {
                        Equipa oldTeam = equipas.FirstOrDefault(t => t.id == oldTeamID);
                        oldTeam.cavalos.Remove(horseToRemove);
                        equipa.money -= cavalo.valor;
                        oldTeam.money += cavalo.valor;

                    }
                    equipa.cavalos.Add(cavalo);
                    Console.WriteLine("Compraste o cavalo com sucesso");
                    
                }
                else
                {
                    Console.WriteLine("Não tens dinheiro suficiente para comprar o cavalo.");
                }

            }




            Console.ReadKey();
            return;

        }

        static void VerificaCorrida()
        {
            foreach (Corrida corrida in corridas)
            {
                if (games.DiaAtual.dia == corrida.data.dia && games.DiaAtual.mes == corrida.data.mes && games.DiaAtual.ano == corrida.data.ano)
                {
                    Corrida();
                }
            }
        }
        static void CarregarFicheiros()
        {

            string equipasJson = File.ReadAllText("equipas.json");
            equipas = JsonConvert.DeserializeObject<List<Equipa>>(equipasJson);

            string cavalosJson = File.ReadAllText("cavalos.json");
            cavalos = JsonConvert.DeserializeObject<List<Cavalo>>(cavalosJson);

            string pistasJson = File.ReadAllText("pistas.json");
            pistas = JsonConvert.DeserializeObject<List<Pista>>(pistasJson);

            string staffsJson = File.ReadAllText("staffs.json");
            staffs = JsonConvert.DeserializeObject<List<Staff>>(staffsJson);

            string ridersJson = File.ReadAllText("riders.json");
            riders = JsonConvert.DeserializeObject<List<Rider>>(ridersJson);

            string corridasJson = File.ReadAllText("corridas.json");
            corridas = JsonConvert.DeserializeObject<List<Corrida>>(corridasJson);

            string gamesJson = File.ReadAllText("games.json");
            games = JsonConvert.DeserializeObject<Game>(gamesJson);

            string eventosJson = File.ReadAllText("eventos.json");
            eventos = JsonConvert.DeserializeObject<List<Evento>>(eventosJson);




        }
        static void SalvarFicheiros()
        {
            string equipasJson = JsonConvert.SerializeObject(equipas);
            File.WriteAllText("equipas.json", equipasJson);

            string cavalosJson = JsonConvert.SerializeObject(cavalos);
            File.WriteAllText("cavalos.json", cavalosJson);

            string pistasJson = JsonConvert.SerializeObject(pistas);
            File.WriteAllText("pistas.json", pistasJson);

            string staffsJson = JsonConvert.SerializeObject(staffs);
            File.WriteAllText("staffs.json", staffsJson);

            string ridersJson = JsonConvert.SerializeObject(riders);
            File.WriteAllText("riders.json", ridersJson);

            string corridasJson = JsonConvert.SerializeObject(corridas);
            File.WriteAllText("corridas.json", corridasJson);

            string gamesJson = JsonConvert.SerializeObject(games);
            File.WriteAllText("games.json", gamesJson);

            string eventosJson = JsonConvert.SerializeObject(eventos);
            File.WriteAllText("eventos.json", eventosJson);

        }
        static void FecharPrograma()
        {
            SalvarFicheiros();
            Environment.Exit(0);
        }

     
    }
}