using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Linq;

namespace Lab_7
{
    public class Purple_1
    {
        public class Participant
        {
            private string _name;
            private string _surname;
            private double[] _coef;
            private int _count;
            private int[,] _marks;
            private double _total;

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

            public double TotalScore
            {
                get
                {
                    return _total;
                }
            }
            public double[] Coefs
            {
                get
                {
                    if (_coef == null) return null;
                    double[] copy = new double[_coef.Length];
                    Array.Copy(_coef, copy, _coef.Length);
                    return copy;
                }
            }
            public int[,] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    int[,] copy_marks = new int[_marks.GetLength(0), _marks.GetLength(1)];
                    for (int i = 0; i < copy_marks.GetLength(0); i++)
                    {
                        for (int j = 0; j < copy_marks.GetLength(1); j++)
                        {
                            copy_marks[i, j] = _marks[i, j];
                        }
                    }
                    return copy_marks;
                }
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _count = 0;
                _coef = new double[4] { 2.5, 2.5, 2.5, 2.5 };
                _marks = new int[4, 7];
                _total = 0;
            }

            public void SetCriterias(double[] coefs)
            {
                if (coefs == null || coefs.Length != 4 || _coef == null) return;
                for (int i = 0; i < coefs.Length; i++)
                {
                    _coef[i] = coefs[i];
                }
            }


            public void Jump(int[] marks)
            {
                if (marks == null || _marks == null || _coef == null) return;
                if (_count >= 4) return;
                for (int i = 0; i < 7; i++)
                {
                    _marks[_count, i] = marks[i];
                }

                int[] array = new int[7];
                for (int j = 0; j < _marks.GetLength(1); j++)
                {
                    array[j] = _marks[_count, j];
                }
                Array.Sort(array);
                for (int k = 1; k < array.Length - 1; k++)
                {
                    _total += array[k] * _coef[_count];
                }
                _count++;
            }

            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j]._total < array[j + 1]._total)
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                    }

                }
            }
            public void Print()
            {
                Console.Write(_name + " ");
                Console.Write(_surname + " ");
                Console.WriteLine(_total + " ");
            }
        }
        public class Judge
        {
            private string _name;
            private int[] _marks;
            private int count;
            public string Name => _name;

            public Judge(string name, int[] marks)
            {
                if (marks == null) return;
                _name = name;
                _marks = new int[marks.Length];
                Array.Copy(marks, _marks, marks.Length);
                count = 0;
            }
            public int CreateMark()
            {
                if (_marks == null || _marks.Length == 0) return 0;
                if (count >= _marks.Length) { count = 0; }
                return _marks[count++];
            }
            public void Print()
            {

            }
        }
        public class Competition
        {
            private Judge[] _judge;
            private Participant[] _participant;
            public Judge[] Judges => _judge;
            public Participant[] Participants => _participant;
            public Competition(Judge[] judge)
            {
                if (judge == null) return;
                _judge = new Judge[judge.Length];
                Array.Copy(judge, _judge, judge.Length);
                _participant = new Participant[0];
            }
            public void Evaluate(Participant jumper)
            {
                if (jumper == null || _judge == null) return;
                int[] marks_for_jumper = new int[7];
                int count = 0;
                foreach (Judge j in _judge)
                {
                    if (j == null) continue;
                    if (count > 6) break;
                    marks_for_jumper[count++] = j.CreateMark();
                }
                jumper.Jump(marks_for_jumper);
            }
            public void Add(Participant participant)
            {
                if (participant == null || _participant == null) return;
                Array.Resize(ref _participant, _participant.Length + 1);
                this.Evaluate(participant);
                _participant[_participant.Length - 1] = participant;
            }
            public void Add(Participant[] participants)
            {
                if (participants == null || _participant == null) return;
                int length = _participant.Length;
                Array.Resize(ref _participant, _participant.Length + participants.Length);
                participants.CopyTo(_participant, length);
                for (int i = length; i < _participant.Length; i++)
                {
                    Evaluate(_participant[i]);
                }
            }
            public void Sort()
            {
                if (_participant == null) return;
                Participant.Sort(_participant);
            }
        }
    }
}
