using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._07._07
{
    class Task2
    {
        public void Task2Logic()
        {

        }

        public Employee[] GetEmployees()
        {
            return new Employee[] {new Employee("Валерий", "Малиновский", 28, "M", "Intetics"),
                new Employee("Сергей", "Марков", 36, "M", "Samsung"),
                new Employee("Ксения", "Мартынюк", 30, "F", "Apple"),
                new Employee("Татьяна", "Милова", 47, "F", "Huawei"),
                new Employee("Ростислав", "Мирошниченко", 29, "M", "Intetics"),
                new Employee("Тимофей", "Мисостов", 28, "M", "Samsung"),
                new Employee("Николай", "Москвин", 27, "M", "Apple"),
                new Employee("Максим", "Нартов", 32, "M", "Intetics"),
                new Employee("Анна", "Новгородова", 32, "F", "LG"),
                new Employee("Константин", "Олексюк", 27, "M", "LG"),
                }; ;

        }
    }
}
