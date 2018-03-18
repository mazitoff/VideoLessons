using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Student
    {
        private int _age;

        public Student() : this(0)
        {

        }
        public Student(int age)
        {
            _age = age;
        }
    }
    struct Teacher
    {
        private int _age;
        private int _weight;
        private int _number;
        public Teacher(int age)
        {
            // в конструкторе структуры обязаловка инициилизировать все поля структуры
            // для инициализации по умолчанию применяется обманка в виде вызова конструктора без параметров:
            this = new Teacher();
            // ------------------
            _age = age;
        }
    }
}
