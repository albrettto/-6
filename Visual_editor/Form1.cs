using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Shape
        {
            Shape()
            {
            }
            ~Shape()
            {
            }
        };
        class Storage
        {
            public Shape[] objects;
            public Storage(int amount)
            {   // Конструктор по умолчанию 
                objects = new Shape[amount];
                for (int i = 0; i < amount; ++i)
                    objects[i] = null;
            }
            public void Initialization(int amount)
            {   // Выделяем amount мест в хранилище
                objects = new Shape[amount];
                for (int i = 0; i < amount; ++i)
                    objects[i] = null;
            }
            public void Add_object(int ind, ref Shape new_object, int count, ref int indexin)
            {   // Добавляет ячейку в хранилище
                // Если ячейка занята ищем свободное место
                while (objects[ind] != null)
                {
                    ind = (ind + 1) % count;
                }
                objects[ind] = new_object;
                indexin = ind;
            }
            public void Delete_object(ref int count_elements)
            {   // Удаляет объект из хранилища
                if (objects[count_elements] != null)
                {
                    objects[count_elements] = null;
                    count_elements--;
                }
            }
            public bool Is_empty(int count_elements)
            {   // Проверяет занято ли место в хранилище
                if (objects[count_elements] == null)
                    return true;
                else return false;
            }
            public int Occupied(int size)
            { // Определяет кол-во занятых мест в хранилище
                int count_occupied = 0;
                for (int i = 0; i < size; ++i)
                    if (!Is_empty(i))
                        ++count_occupied;
                return count_occupied;
            }
            public void Increase_Storage(ref int size)
            { // Увеличивает хранилище в 2 раза
                Storage new_storage = new Storage(size * 2);
                for (int i = 0; i < size; ++i)
                    new_storage.objects[i] = objects[i];
                for (int i = size; i < (size * 2) - 1; ++i)
                {
                    new_storage.objects[i] = null;
                }
                size = size * 2;
                Initialization(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = new_storage.objects[i];
            }
            ~Storage() { }
        };
    }
}
