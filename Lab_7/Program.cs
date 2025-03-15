using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Programm
    {
        static void Main()
        {

            Purple_1.Participant jumper1 = new Purple_1.Participant("Дарья", "Тихонова");
            jumper1.SetCriterias(new double[] { 2.58, 2.9, 3.04, 3.43 });
            jumper1.Jump(new int[] { 3, 4, 1, 2, 1, 3, 1 });
            jumper1.Jump(new int[] { 5, 3, 4, 3, 3, 3, 3 });
            jumper1.Jump(new int[] { 2, 4, 1, 5, 6, 1, 2 });
            jumper1.Jump(new int[] { 6, 4, 3, 2, 2, 1, 1 });

            Purple_1.Participant jumper2 = new Purple_1.Participant("Александр", "Козлов");
            jumper2.SetCriterias(new double[] { 2.95, 2.63, 3.16, 2.89 });
            jumper2.Jump(new int[] { 3, 5, 4, 4, 5, 1, 4 });
            jumper2.Jump(new int[] { 1, 6, 5, 2, 1, 4, 1 });
            jumper2.Jump(new int[] { 6, 2, 4, 1, 2, 6, 5 });
            jumper2.Jump(new int[] { 6, 5, 2, 2, 4, 3, 4 });

            // 3. Никита Павлов
            Purple_1.Participant jumper3 = new Purple_1.Participant("Никита", "Павлов");
            jumper3.SetCriterias(new double[] { 2.56, 3.40, 2.91, 2.69 });
            jumper3.Jump(new int[] { 1, 1, 3, 5, 5, 5, 2 });
            jumper3.Jump(new int[] { 4, 1, 1, 2, 2, 2, 5 });
            jumper3.Jump(new int[] { 5, 2, 3, 3, 2, 2, 3 });
            jumper3.Jump(new int[] { 3, 1, 3, 4, 2, 4, 5 });

            // 4. Юрий Луговой
            Purple_1.Participant jumper4 = new Purple_1.Participant("Юрий", "Луговой");
            jumper4.SetCriterias(new double[] { 2.86, 2.90, 3.19, 3.14 });
            jumper4.Jump(new int[] { 3, 3, 5, 2, 1, 2, 4 });
            jumper4.Jump(new int[] { 5, 5, 4, 2, 3, 2, 2 });
            jumper4.Jump(new int[] { 6, 3, 1, 2, 2, 6, 6 });
            jumper4.Jump(new int[] { 5, 1, 6, 6, 3, 2, 5 });

            // 5. Юрий Степанов
            Purple_1.Participant jumper5 = new Purple_1.Participant("Юрий", "Степанов");
            jumper5.SetCriterias(new double[] { 2.81, 2.64, 2.76, 3.20 });
            jumper5.Jump(new int[] { 4, 3, 5, 4, 5, 1, 1 });
            jumper5.Jump(new int[] { 5, 3, 4, 2, 1, 1, 2 });
            jumper5.Jump(new int[] { 2, 2, 4, 2, 6, 3, 4 });
            jumper5.Jump(new int[] { 3, 2, 1, 3, 5, 1, 5 });

            // 6. Мария Луговая
            Purple_1.Participant jumper6 = new Purple_1.Participant("Мария", "Луговая");
            jumper6.SetCriterias(new double[] { 2.74, 3.30, 2.94, 3.27 });
            jumper6.Jump(new int[] { 6, 5, 5, 4, 2, 6, 4 });
            jumper6.Jump(new int[] { 5, 4, 3, 2, 4, 6, 1 });
            jumper6.Jump(new int[] { 1, 1, 3, 4, 4, 1, 6 });
            jumper6.Jump(new int[] { 3, 1, 5, 1, 4, 3, 1 });

            // 7. Виктор Жарков
            Purple_1.Participant jumper7 = new Purple_1.Participant("Виктор", "Жарков");
            jumper7.SetCriterias(new double[] { 2.57, 2.79, 2.71, 3.46 });
            jumper7.Jump(new int[] { 4, 6, 1, 4, 5, 3, 4 });
            jumper7.Jump(new int[] { 1, 2, 3, 1, 5, 4, 3 });
            jumper7.Jump(new int[] { 3, 6, 2, 3, 1, 6, 3 });
            jumper7.Jump(new int[] { 3, 3, 6, 6, 3, 6, 6 });

            // 8. Марина Иванова
            Purple_1.Participant jumper8 = new Purple_1.Participant("Марина", "Иванова");
            jumper8.SetCriterias(new double[] { 3.09, 2.67, 2.90, 3.50 });
            jumper8.Jump(new int[] { 6, 5, 3, 2, 6, 5, 3 });
            jumper8.Jump(new int[] { 5, 4, 4, 2, 1, 2, 4 });
            jumper8.Jump(new int[] { 4, 2, 2, 5, 1, 3, 1 });
            jumper8.Jump(new int[] { 6, 5, 6, 1, 6, 3, 3 });

            // 9. Марина Полевая
            Purple_1.Participant jumper9 = new Purple_1.Participant("Марина", "Полевая");
            jumper9.SetCriterias(new double[] { 2.65, 3.47, 3.11, 3.39 });
            jumper9.Jump(new int[] { 3, 6, 3, 5, 4, 2, 3 });
            jumper9.Jump(new int[] { 4, 6, 1, 4, 2, 1, 5 });
            jumper9.Jump(new int[] { 1, 1, 3, 1, 3, 2, 6 });
            jumper9.Jump(new int[] { 1, 4, 4, 6, 6, 2, 5 });

            // 10. Максим Тихонов
            Purple_1.Participant jumper10 = new Purple_1.Participant("Максим", "Тихонов");
            jumper10.SetCriterias(new double[] { 3.14, 3.46, 2.96, 2.76 });
            jumper10.Jump(new int[] { 3, 3, 1, 4, 5, 6, 2 });
            jumper10.Jump(new int[] { 6, 4, 5, 4, 2, 3, 1 });
            jumper10.Jump(new int[] { 3, 3, 4, 2, 2, 3, 6 });
            jumper10.Jump(new int[] { 5, 1, 5, 5, 1, 3, 4 });

            Purple_1.Participant[] participants = new Purple_1.Participant[10] { jumper1, jumper2, jumper3, jumper4, jumper5, jumper6, jumper7, jumper8, jumper9, jumper10 };
            Purple_1.Participant.Sort(participants);
            foreach (var participant in participants)
            {
                participant.Print();
            }


            Purple_3.Participant person1 = new Purple_3.Participant("Виктор", "Полевой");
            person1.Evaluate(5.93);
            person1.Evaluate(5.44);
            person1.Evaluate(1.20);
            person1.Evaluate(0.28);
            person1.Evaluate(1.57);
            person1.Evaluate(1.86);
            person1.Evaluate(5.89);

            Purple_3.Participant person2 = new Purple_3.Participant("Алиса", "Козлова");
            person2.Evaluate(1.68);
            person2.Evaluate(3.79);
            person2.Evaluate(3.62);
            person2.Evaluate(2.76);
            person2.Evaluate(4.47);
            person2.Evaluate(4.26);
            person2.Evaluate(5.79);

            Purple_3.Participant person3 = new Purple_3.Participant("Ярослав", "Зайцев");
            person3.Evaluate(2.93);
            person3.Evaluate(3.10);
            person3.Evaluate(5.46);
            person3.Evaluate(4.88);
            person3.Evaluate(3.99);
            person3.Evaluate(4.79);
            person3.Evaluate(5.56);

            Purple_3.Participant person4 = new Purple_3.Participant("Савелий", "Кристиан");
            person4.Evaluate(4.20);
            person4.Evaluate(4.69);
            person4.Evaluate(3.90);
            person4.Evaluate(1.67);
            person4.Evaluate(1.13);
            person4.Evaluate(5.66);
            person4.Evaluate(5.40);

            Purple_3.Participant person5 = new Purple_3.Participant("Алиса", "Козлова");
            person5.Evaluate(3.27);
            person5.Evaluate(2.43);
            person5.Evaluate(0.90);
            person5.Evaluate(5.61);
            person5.Evaluate(3.12);
            person5.Evaluate(3.76);
            person5.Evaluate(3.73);

            Purple_3.Participant person6 = new Purple_3.Participant("Алиса", "Луговая");
            person6.Evaluate(0.75);
            person6.Evaluate(1.13);
            person6.Evaluate(5.43);
            person6.Evaluate(2.07);
            person6.Evaluate(2.68);
            person6.Evaluate(0.83);
            person6.Evaluate(3.68);

            Purple_3.Participant person7 = new Purple_3.Participant("Александр", "Петров");
            person7.Evaluate(3.78);
            person7.Evaluate(3.42);
            person7.Evaluate(3.84);
            person7.Evaluate(2.19);
            person7.Evaluate(1.20);
            person7.Evaluate(2.51);
            person7.Evaluate(3.51);

            Purple_3.Participant person8 = new Purple_3.Participant("Мария", "Смирнова");
            person8.Evaluate(1.35);
            person8.Evaluate(3.40);
            person8.Evaluate(1.85);
            person8.Evaluate(2.02);
            person8.Evaluate(2.78);
            person8.Evaluate(3.23);
            person8.Evaluate(3.03);

            Purple_3.Participant person9 = new Purple_3.Participant("Полина", "Сидорова");
            person9.Evaluate(0.55);
            person9.Evaluate(5.93);
            person9.Evaluate(0.75);
            person9.Evaluate(5.15);
            person9.Evaluate(4.35);
            person9.Evaluate(1.51);
            person9.Evaluate(2.77);

            Purple_3.Participant person10 = new Purple_3.Participant("Татьяна", "Сидорова");
            person10.Evaluate(3.86);
            person10.Evaluate(0.19);
            person10.Evaluate(0.46);
            person10.Evaluate(5.14);
            person10.Evaluate(5.37);
            person10.Evaluate(0.94);
            person10.Evaluate(0.84);

            Purple_3.Participant[] list_person = new Purple_3.Participant[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            Purple_3.Participant.SetPlaces(list_person);
            Purple_3.Participant.Sort(list_person);
            Console.WriteLine("------------------------------------------------------------------");

            foreach (var item in list_person) item.Print();




            Purple_4.Sportsman sportsman1 = new Purple_4.Sportsman("Полина", "Луговская");
            sportsman1.Run(422.64);
            Purple_4.Sportsman sportsman2 = new Purple_4.Sportsman("Савелий", "Козлов");
            sportsman2.Run(142.05);

            Purple_4.Sportsman sportsman3 = new Purple_4.Sportsman("Екатерина", "Жаркова");
            sportsman3.Run(185.23);

            Purple_4.Sportsman sportsman4 = new Purple_4.Sportsman("Дмитрий", "Иванов");
            sportsman4.Run(294.32);

            Purple_4.Sportsman sportsman5 = new Purple_4.Sportsman("Дмитрий", "Полевой");
            sportsman5.Run(79.26);

            Purple_4.Sportsman sportsman6 = new Purple_4.Sportsman("Савелий", "Петров");
            sportsman6.Run(230.63);

            Purple_4.Sportsman sportsman7 = new Purple_4.Sportsman("Евгения", "Распутина");
            sportsman7.Run(35.16);

            Purple_4.Sportsman sportsman8 = new Purple_4.Sportsman("Екатерина", "Луговская");
            sportsman8.Run(376.12);

            Purple_4.Sportsman sportsman9 = new Purple_4.Sportsman("Мария", "Иванова");
            sportsman9.Run(279.20);

            Purple_4.Sportsman sportsman10 = new Purple_4.Sportsman("Степан", "Павлов");
            sportsman10.Run(292.38);

            Purple_4.Sportsman sportsman11 = new Purple_4.Sportsman("Ольга", "Павлова");
            sportsman11.Run(467.60);

            Purple_4.Sportsman sportsman12 = new Purple_4.Sportsman("Ольга", "Полевая");
            sportsman12.Run(473.82);

            Purple_4.Sportsman sportsman13 = new Purple_4.Sportsman("Дарья", "Павлова");
            sportsman13.Run(290.14);

            Purple_4.Sportsman sportsman14 = new Purple_4.Sportsman("Дарья", "Свиридова");
            sportsman14.Run(368.60);

            Purple_4.Sportsman sportsman15 = new Purple_4.Sportsman("Евгения", "Свиридова");
            sportsman15.Run(212.67);

            Purple_4.Group group1 = new Purple_4.Group("Группа 1");
            group1.Add(sportsman1);
            group1.Add(sportsman2);
            group1.Add(sportsman3);
            group1.Add(sportsman4);
            group1.Add(sportsman5);
            group1.Add(sportsman6);
            group1.Add(sportsman7);
            group1.Add(sportsman8);
            group1.Add(sportsman9);
            group1.Add(sportsman10);
            group1.Add(sportsman11);
            group1.Add(sportsman12);
            group1.Add(sportsman13);
            group1.Add(sportsman14);
            group1.Add(sportsman15);
            group1.Sort();
            Purple_4.Sportsman sportsman16 = new Purple_4.Sportsman("Анастасия", "Жаркова");
            sportsman16.Run(112.49);

            Purple_4.Sportsman sportsman17 = new Purple_4.Sportsman("Александр", "Павлов");
            sportsman17.Run(472.11);

            Purple_4.Sportsman sportsman18 = new Purple_4.Sportsman("Степан", "Свиридов");
            sportsman18.Run(213.92);

            Purple_4.Sportsman sportsman19 = new Purple_4.Sportsman("Игорь", "Сидоров");
            sportsman19.Run(102.13);

            Purple_4.Sportsman sportsman20 = new Purple_4.Sportsman("Евгения", "Сидорова");
            sportsman20.Run(263.21);

            Purple_4.Sportsman sportsman21 = new Purple_4.Sportsman("Мария", "Сидорова");
            sportsman21.Run(350.75);

            Purple_4.Sportsman sportsman22 = new Purple_4.Sportsman("Лев", "Петров");
            sportsman22.Run(248.68);

            Purple_4.Sportsman sportsman23 = new Purple_4.Sportsman("Савелий", "Козлов");
            sportsman23.Run(325.28);

            Purple_4.Sportsman sportsman24 = new Purple_4.Sportsman("Егор", "Свиридов");
            sportsman24.Run(300.00);

            Purple_4.Sportsman sportsman25 = new Purple_4.Sportsman("Оксана", "Жаркова");
            sportsman25.Run(252.16);

            Purple_4.Sportsman sportsman26 = new Purple_4.Sportsman("Светлана", "Петрова");
            sportsman26.Run(402.20);

            Purple_4.Sportsman sportsman27 = new Purple_4.Sportsman("Полина", "Петрова");
            sportsman27.Run(397.33);

            Purple_4.Sportsman sportsman28 = new Purple_4.Sportsman("Екатерина", "Павлова");
            sportsman28.Run(384.94);

            Purple_4.Sportsman sportsman29 = new Purple_4.Sportsman("Юлия", "Полевая");
            sportsman29.Run(8.09);

            Purple_4.Sportsman sportsman30 = new Purple_4.Sportsman("Евгения", "Павлова");
            sportsman30.Run(480.52);

            Purple_4.Group group2 = new Purple_4.Group("Группа 2");
            group2.Add(sportsman16);
            group2.Add(sportsman17);
            group2.Add(sportsman18);
            group2.Add(sportsman19);
            group2.Add(sportsman20);
            group2.Add(sportsman21);
            group2.Add(sportsman22);
            group2.Add(sportsman23);
            group2.Add(sportsman24);
            group2.Add(sportsman25);
            group2.Add(sportsman26);
            group2.Add(sportsman27);
            group2.Add(sportsman28);
            group2.Add(sportsman29);
            group2.Add(sportsman30);
            group2.Sort();
            Console.WriteLine("-----------------");
            Purple_4.Group final_group = Purple_4.Group.Merge(group1, group2);
            final_group.Print();


            Console.WriteLine("-----------------");
            Purple_5.Research research = new Purple_5.Research("test");
            research.Add(new string[] { "Макака", "-", "Манга" });
            research.Add(new string[] { "Тануки", "Проницательность", "Манга" });
            research.Add(new string[] { "Тануки", "Скромность", "Кимоно" });
            research.Add(new string[] { "Кошка", "Внимательность", "Суши" });
            research.Add(new string[] { "Сима_энага", "Дружелюбность", "Кимоно" });
            research.Add(new string[] { "Макака", "Внимательность", "Самурай" });
            research.Add(new string[] { "Панда", "Проницательность", "Манга" });
            research.Add(new string[] { "Сима_энага", "Проницательность", "Суши" });
            research.Add(new string[] { "Серау", "Внимательность", "Сакура" });
            research.Add(new string[] { "Панда", "-", "Кимоно" });
            research.Add(new string[] { "Сима_энага", "Дружелюбность", "Сакура" });
            research.Add(new string[] { "Кошка", "Внимательность", "Кимоно" });
            research.Add(new string[] { "Панда", "-", "Сакура" });
            research.Add(new string[] { "Кошка", "Уважительность", "Фудзияма" });
            research.Add(new string[] { "Панда", "Целеустремленность", "Аниме" });
            research.Add(new string[] { "Серау", "Дружелюбность", "-" });
            research.Add(new string[] { "Панда", "-", "Манга" });
            research.Add(new string[] { "Сима_энага", "Скромность", "Фудзияма" });
            research.Add(new string[] { "Панда", "Проницательность", "Самурай" });
            research.Add(new string[] { "Кошка", "Внимательность", "Сакура" });
            research.Print();






        }
    }
}