using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Purple_2
    {
        public abstract class SkiJumping
        {
            private string _nameOfcompetition;
            private int _nameOfstandard;
            private Participant[] _participants;

            public string Name => _nameOfcompetition;
            public int Standart => _nameOfstandard;
            public Participant[] Participants => _participants;
            public SkiJumping(string nameOfcompetition, int nameOfstandard)
            {
                _nameOfcompetition = nameOfcompetition;
                _nameOfstandard = nameOfstandard;
                _participants = new Participant[0];
            }

            public void Add(Participant participant)
            {
                if (_participants == null) return;
                Array.Resize(ref _participants, _participants.Length + 1);
                _participants[_participants.Length - 1] = participant;
            }
            public void Add(Participant[] participants)
            {
                if (_participants == null || participants == null) return;
                foreach (Participant p in participants)
                {
                    this.Add(p);
                }
            }

            public void Jump(int distance, int[] marks)
            {
                foreach (Participant p in _participants)
                {
                    if (p.Marks != null && p.Marks.All(m => m == 0))
                    {
                        p.Jump(distance, marks, _nameOfstandard);
                        break;
                    }

                }

            }
            public void Print()
            {

            }
        }
        public class JuniorSkyJumping : SkiJumping
        {
            public JuniorSkyJumping() : base("100m", 100)
            {

            }
        }
        public class ProSkiJumping : SkiJumping
        {
            public ProSkiJumping() : base("150m", 150)
            {

            }
        }
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int _distance;
            private int[] _marks;
            private int _result;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }

            public int Distance { get { return _distance; } }
            public int[] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    int[] copy = new int[_marks.Length];
                    Array.Copy(_marks, copy, copy.Length);
                    return copy;
                }
            }

            public int Result { get { return _result; } }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[5];
            }

            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j]._result < array[j + 1]._result)
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
                Console.WriteLine(_result + " ");
            }

            public void Jump(int distance, int[] marks, int target)
            {
                if (marks == null || marks.Length != 5 || _marks == null || target < 0) return;
                if (distance < 0) return;
                _distance = distance;

                for (int i = 0; i < marks.Length; i++)
                {
                    _marks[i] = marks[i];
                }

                Array.Sort(marks);

                for (int i = 1; i < marks.Length - 1; i++)
                {

                    _result += marks[i];
                }

                if (distance - target >= 0)
                {
                    _result += 60;
                    _result += (distance - target) * 2;
                }

                else
                {
                    _result += 60;
                    _result -= (target - distance) * 2;
                    if (_result < 0) _result = 0;
                }
            }
        }

    }
}
