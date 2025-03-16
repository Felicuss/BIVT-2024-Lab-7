using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Purple_3
    {
        public struct Participant
        {
            //Переменные
            private string _name;
            private string _surname;
            private double[] _marks;
            private int[] _places;
            private int count = 0;

            //Свойства
            public string Name
            {
                get
                {
                    return _name;
                }
            }
            public string Surname
            {
                get
                {
                    return _surname;
                }
            }
            public double[] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    double[] copy = new double[_marks.Length];
                    Array.Copy(_marks, copy, copy.Length);
                    return copy;
                }
            }
            public int[] Places
            {
                get
                {
                    if (_places == null) return null;
                    int[] copy = new int[_places.Length];
                    Array.Copy(_places, copy, copy.Length);
                    return copy;
                }
            }

            public int Score
            {
                get
                {
                    if (_places == null) return 0;
                    int sc = 0;
                    for (int i = 0; i < _places.Length; i++)
                    {
                        sc += _places[i];
                    }
                    return sc;
                }
            }

            private double TotalMark
            {
                get
                {
                    if (_marks == null) return 0;
                    double marks = 0;
                    foreach (double mark in _marks)
                    {
                        marks += mark;
                    }
                    return Math.Round(marks, 2);
                }
            }

            private int TopPlace
            {
                get
                {
                    if (_places == null) return 0;
                    int top = int.MaxValue;
                    foreach (int i in _places)
                    {
                        if (i < top) top = i;
                    }
                    return top;
                }
            }
            //Конструктор
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new double[7];
                _places = new int[7];
            }

            //Добавление новой оценки
            public void Evaluate(double result)
            {
                if (_marks == null) return;
                if (count <= 6)
                {
                    _marks[count++] = result;
                }
                else
                {
                    return;
                }
            }

            //Определение мест у судьей
            public static void SetPlaces(Participant[] participants)
            {
                if (participants == null || participants.Length == 0) return;
                //Идем по судьям
                for (int i = 0; i < 7; i++)
                {
                    //Сортируем участников в зависимости от оценок. Итог - массив от самой высокой до самой низкой оценки
                    for (int b = 0; b < participants.Length - 1; b++)
                    {
                        for (int c = 0; c < participants.Length - 1 - b; c++)
                        {
                            if (participants[c]._marks == null || participants[c + 1]._marks == null || participants[c]._places == null || participants[c + 1]._places == null) continue;
                            if (participants[c]._marks[i] < participants[c + 1]._marks[i])
                            {
                                (participants[c], participants[c + 1]) = (participants[c + 1], participants[c]);
                            }
                        }
                    }
                    //Теперь мы идем по участникам (отсортированным) и ставим их места у судьи i
                    for (int person = 0; person < participants.Length; person++)
                    {
                        if (participants[person]._places == null || participants[person]._marks == null) continue;
                        participants[person]._places[i] = person + 1;
                    }
                }
            }


            //Условие для сортировки немного не понял, надеюсь, что правильно
            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                //Сначала люди, которые выше всех, далее ниже
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j + 1]._places == null || array[j]._places == null || array[j + 1]._marks == null || array[j]._marks == null) continue;
                        //Если набрал меньше "хороших мест" идет вниз
                        if (array[j].Score > array[j + 1].Score)
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                        //Если одинаковая сумма мест
                        else if (array[j].Score == array[j + 1].Score)
                        {
                            bool flag = false;
                            int max_for_first = int.MaxValue;
                            int max_for_second = int.MaxValue;
                            //Сравниваем всех судей. Считаем у кого более лучших мест больше
                            for (int judge = 0; judge < 7; judge++)
                            {
                                if (array[j + 1]._places[judge] < max_for_second)
                                {
                                    max_for_second = array[j + 1]._places[judge];
                                }
                                if (array[j]._places[judge] < max_for_first)
                                {
                                    max_for_first = array[j]._places[judge];
                                    //У первого место более "лучше"
                                }
                            }
                            //Если у первого человека максимальное место больше - ничего не делаем
                            if (max_for_first < max_for_second)
                            {
                                flag = true;
                            }
                            //Если у второго человека максимальное место больше - меняем местами
                            else if (max_for_second < max_for_first)
                            {
                                flag = true;
                                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                            }
                            //Если равно
                            if (flag == false)
                            {
                                //Считаем сумму очков у первого и второго
                                double sum1 = 0;
                                double sum2 = 0;
                                for (int mark = 0; mark < 7; mark++)
                                {
                                    sum1 += array[j]._marks[mark];
                                    sum2 += array[j + 1]._marks[mark];
                                }
                                //Если у первого очков меньше - меняем местами (он в более проигрышной позиции)
                                if (sum1 < sum2)
                                {
                                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                                }
                            }

                        }
                    }
                }
            }
            public void Print()
            {

                Console.Write(Name + "      ");
                Console.Write(Surname + "        ");
                Console.Write(Score + "       ");
                Console.Write(TopPlace + "       ");
                Console.WriteLine(TotalMark + "       ");

            }
        }
        public abstract class Skating
        {
            protected Participant[] _participants;
            protected double[] _moods;
            public Participant[] Participants => _participants;
            public double[] Moods => _moods;
            public Skating(double[] moods)
            {
                _participants = new Participant[0];
                if (moods == null)
                {
                    moods = new double[0];
                    return;
                }
                _moods = new double[moods.Length];
                Array.Copy(moods, _moods, _moods.Length);

                ModificateMood();
            }

            protected abstract void ModificateMood();
            public void Evaluate(double[] marks)
            {
                if (marks == null || _participants == null || _moods == null) return;
                var sp = _participants.Select(p => p).Where(p => p.Marks != null && p.Marks.All(m => m == 0)).ToArray();
                if (sp.Length == 0) return;
                var first_person = sp[0];
                int index = 0;
                for (int i = 0; i < _participants.Length; i++)
                {
                    if (_participants[i].Equals(first_person))
                    {
                        index = i;
                        break;
                    }
                }
                for (int i = 0; i < marks.Length; i++) _participants[index].Evaluate(marks[i] * _moods[i]);
            }
            public void Add(Participant p)
            {
                if (_participants == null) _participants = new Participant[0];
                Array.Resize(ref _participants, _participants.Length + 1);
                _participants[_participants.Length - 1] = p;
            }
            public void Add(Participant[] ps)
            {
                if (_participants == null || ps == null) return;
                int length = _participants.Length;
                Array.Resize(ref _participants, ps.Length + _participants.Length);
                ps.CopyTo(_participants, length);
            }
        }
        public class FigureSkating : Skating
        {
            public FigureSkating(double[] moods) : base(moods)
            {

            }
            protected override void ModificateMood()
            {
                if (Moods == null) return;
                for (int i = 0; i < _moods.Length; i++)
                {
                    _moods[i] += (i + 1) / 10.0;
                }

            }
        }
        public class IceSkating : Skating
        {
            public IceSkating(double[] moods) : base(moods)
            {

            }
            protected override void ModificateMood()
            {
                if (Moods == null) return;
                for (int i = 0; i < _moods.Length; i++)
                {
                    _moods[i] *= (1 + (i + 1) / 100.0);
                }
            }
        }
    }
}
