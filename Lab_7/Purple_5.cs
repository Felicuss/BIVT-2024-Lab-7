using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_7.Purple_5;
namespace Lab_7
{
    public class Purple_5
    {
        public struct Response
        {
            private string _animal;
            private string _characterTrait;
            private string _concept;

            public string Animal
            {
                get
                {
                    return _animal;
                }
            }
            public string CharacterTrait
            {
                get
                {
                    return _characterTrait;
                }
            }
            public string Concept
            {
                get
                {
                    return _concept;
                }
            }
            public Response(string animal, string characterTrait, string concept)
            {
                _animal = animal;
                _characterTrait = characterTrait;
                _concept = concept;
            }
            public int CountVotes(Response[] responses, int questionNumber)
            {
                if (responses == null) return 0;
                if (questionNumber < 1 || questionNumber > 3) return 0;
                int count = 0;
                foreach (Response response in responses)
                {
                    if (questionNumber == 1 && response._animal != null && response._animal == this._animal)
                    {
                        count++;
                    }
                    if (questionNumber == 2 && response._characterTrait != null && response._characterTrait == this._characterTrait)
                    {
                        count++;
                    }
                    if (questionNumber == 3 && response._concept != null && response._concept == this._concept)
                    {
                        count++;
                    }
                }
                return count;
            }
            public void Print()
            {
                Console.Write(_animal + "      ");
                Console.Write(_characterTrait + "      ");
                Console.WriteLine(_concept + "      ");
            }

        }

        public struct Research
        {
            private string _name;
            private Response[] _responses;
            public string Name { get { return _name; } }
            public Response[] Responses { get { return _responses; } }
            public Research(string name)
            {
                _name = name;
                _responses = new Response[0];
            }
            public void Add(string[] answers)
            {
                if (answers == null || answers.Length != 3 || _responses == null) return;
                Array.Resize(ref _responses, _responses.Length + 1);
                _responses[_responses.Length - 1] = new Response(answers[0], answers[1], answers[2]);
            }
            private string Answer(int question, Response r)
            {
                string answer;
                switch (question)
                {
                    case 1:
                        answer = r.Animal;
                        break;
                    case 2:
                        answer = r.CharacterTrait;
                        break;
                    case 3:
                        answer = r.Concept;
                        break;
                    default:
                        return null;
                }
                return answer;
            }
            public string[] GetTopResponses(int question)
            {
                if (_responses == null || question < 1 || question > 3) return null;
                string[] list = new string[0];
                foreach (Response response in _responses)
                {
                    //Сначала создадим новый массив, и в него будем сохранять только УНИКАЛЬНЫЕ элементы
                    string answer = Answer(question, response);
                    if (answer == null) continue;
                    bool flag = false; //Нет таких элементов в нашем массиве

                    //Проходимся по всему массиву list
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i] == answer)
                        {
                            flag = true; break;
                            //Если такой элемент уже есть то стопаем
                        }
                    }
                    //Если такого элемента нет - добавляем его
                    if (!flag)
                    {
                        Array.Resize(ref list, list.Length + 1);
                        list[list.Length - 1] = answer;
                    }
                }
                //Получаем массив с уникальными элементами
                //Теперь сделаем массив, который хранит в себе количество этих элементов
                int[] count_list = new int[list.Length];
                for (int j = 0; j < list.Length; j++)
                {
                    int count = 0;
                    foreach (Response response in _responses)
                    {
                        string answer = Answer(question, response);
                        if (answer == list[j])
                        {
                            count++;
                        }
                    }
                    count_list[j] = count;
                }
                //Получили массив самых популярных ответов, теперь отсортируем сами ответы в порядке убывания по пузырьковой)))
                for (int i = 0; i < list.Length - 1; i++)
                {
                    for (int j = 0; j < list.Length - 1 - i; j++)
                    {
                        if (count_list[j] < count_list[j + 1])
                        {
                            (count_list[j], count_list[j + 1]) = (count_list[j + 1], count_list[j]);
                            (list[j], list[j + 1]) = (list[j + 1], list[j]);
                        }
                    }
                }
                //Получили отсортированный по убыванию массив с ответами
                int c = Math.Min(list.Length, 5);
                string[] first_c_elements = new string[c];
                for (int i = 0; i < c; i++)
                {
                    first_c_elements[i] = list[i];
                }
                return first_c_elements;
            }

            private int CountOfAnswer(int question, string answer)
            {
                if (question < 1 || question > 3 || answer == null || _responses == null) return 0;
                int count = 0;
                foreach (var r in _responses)
                {
                    string answer_of_person = Answer(question, r);
                    if (answer_of_person == answer)
                    {
                        count++;
                    }
                }
                return count;
            }
            public void Print()
            {
                if (_responses == null) return;
                for (int i = 0; i < 3; i++)
                {
                    string[] an = GetTopResponses(i + 1);
                    if (an == null) return;
                    for (int j = 0; j < an.Length; j++)
                    {
                        Console.Write(an[j] + "    ");
                        Console.WriteLine(CountOfAnswer(i + 1, an[j]));
                    }
                    Console.WriteLine();
                }
            }
        }
        public class Report
        {
            private Research[] _researches;
            public Research[] Researches => _researches;
            private static int _numbering;
            static Report()
            {
                _numbering = 1;
            }
            public Report()
            {
                _researches = new Research[0];
            }
            public Research MakeResearch()
            {
                if (_researches == null) return new Research("Error");
                DateTime date = DateTime.Now;
                Research re = new Research($"No_{_numbering}_{date.Month}/{date.Year % 100}");
                Array.Resize(ref _researches, _researches.Length + 1);
                _researches[_researches.Length - 1] = re;
                _numbering++;
                return re;
            }


            public (string, double)[] GetGeneralReport(int question)
            {
                if (_researches == null || question <= 0 || question > 3) return null;
                var responses = _researches.SelectMany(re => re.Responses).Where(resp => Answer(question, resp) != null).ToArray();
                double answer_count = responses.Length;
                var all_answers = responses.Select(re => Answer(question, re)).ToArray();
                var result = all_answers.GroupBy(x => x).Select(g => (g.Key, (g.Count() / answer_count) * 100)).ToArray();
                return result;
            }

            private string Answer(int question, Response r)
            {
                string answer;
                switch (question)
                {
                    case 1:
                        answer = r.Animal;
                        break;
                    case 2:
                        answer = r.CharacterTrait;
                        break;
                    case 3:
                        answer = r.Concept;
                        break;
                    default:
                        return null;
                }
                return answer;
            }
        }

    }
}
