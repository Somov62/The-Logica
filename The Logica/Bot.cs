using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Logica
{
    class Bot
    {
        private readonly List<int> _code;
        public Bot()
        {
            _code = CreateCode();
        }
        public List<int> Code { get => _code; }

        private List<int> CreateCode()
        {
            List<int> code = new();
            code.Capacity = 5;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                code.Add(rnd.Next(0, Colors.ListColors.Count));
            }
            return code;
        }

        public List<int> CheckCode(List<int> attempt)
        {
            List<int> code = new(_code);
            List<int> response = new();
            response.Capacity = 5;
            for (int i = 0; i < code.Count; i++)
            {
                if (code[i] != attempt[i]) continue;

                response.Add(8);
                code.RemoveAt(i);
                attempt.RemoveAt(i);
                i--;
            }
            for (int i = 0; i < code.Count; i++)
            {
                if (attempt.Where(p => p == code[i]).Count() > 1)
                {
                    response.Add(2);
                    continue;
                }
                if (attempt.Contains(code[i]))
                {
                    response.Add(2);
                }
            }
            return response;
        }

        public bool CheckWin(List<int> responseList)
        {
            if (responseList.Count != _code.Count) return false;
            foreach (var item in responseList)
            {
                if (item != 8) return false;
            }
            return true;
        }
    }
}
