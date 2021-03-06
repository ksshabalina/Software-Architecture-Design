﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CreateSoup1 : AbstractFood1
    {
        public string NameFood1()
        {
            return "Борщ";
        }

        public string HelpFood1(AbstractFood2 help1, AbstractFood3 help2)
        {
            var result1 = help1.NameFood2();
            var result2 = help2.NameFood3();

            return $"Предложите клиенту {result1} и {result2}";
        }

        private static CreateSoup1 instance;

        public static CreateSoup1 GetInstance()
        {
            if (instance == null)
            {
                instance = new CreateSoup1();
            }
            return instance;
        }
    }
}
