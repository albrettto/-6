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
        //MVC model;
        public Form1()
        {
            InitializeComponent();
            //model = new MVC();
            //model.observers += new System.EventHandler(this.updateFromMVC);
        }
        class Shape
        {
            private Color color = default_color;
            private bool is_selected = false;
            public int move = 60; // смещение от цетра к вершинам
            public Shape()
            {
            }
            public void SetColor(Color color)
            {
                this.color = color;
            }
            public Color GetColor()
            {
                return color;
            }
            public void Select(bool is_selected)
            {
                this.is_selected = is_selected;
            }
            public bool IsSelected()
            {
                return is_selected;
            }
        };
        class Circle : Shape
        {
            public int x, y;
            public Circle() // Конструктор по умолчанию
            {
                x = 0;
                y = 0;
            }
            public Circle(int x, int y) // Конструктор с параметрами
            {
                this.x = x - move / 2;
                this.y = y - move / 2;
            }
        }
        class Triangle: Shape
        {
            public int x1, y1, x2, y2, x3, y3;
            public Triangle() // Конструктор по умолчанию
            {
                x1 = 0; y1 = 0;
                x2 = 0; y2 = 0;
                x3 = 0; y3 = 0;
            }
            public Triangle(int x, int y) // Конструктор с параметрами
            {
                x1 = x; y1 = y - move * 2 / 3;
                x2 = x - move * 2 / 3; y2 = y + move / 3;
                x3 = x + move * 2 / 3; y3 = y + move / 3;
            }
        }
        class Square: Shape
        {
            public int x1, y1, x2, y2, x3, y3, x4, y4;
            public Square() // Конструктор по умолчанию
            {
                x1 = 0; y1 = 0;
                x2 = 0; y2 = 0;
                x3 = 0; y3 = 0;
                x4 = 0; y4 = 0;

            }
            public Square(int x, int y) // Конструктор с параметрами
            {
                x1 = x - move / 2; y1 = y + move / 2;
                x2 = x + move / 2; y2 = y + move / 2;
                x3 = x + move / 2; y3 = y - move / 2;
                x4 = x - move / 2; y4 = y - move / 2;
            }
        }
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
                size *=2;
                Initialization(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = new_storage.objects[i];
            }
            ~Storage() { }
        };
        //public class MVC
        //{
        //    private Color color;
        //    private string name_color;
        //    public System.EventHandler observers;
        //    public void setColor(Color color, string name_color)
        //    {
        //        this.color = color;
        //        this.name_color = name_color;
        //        observers.Invoke(this, null);
        //    }
        //    public Color getColor()
        //    {
        //        return color;
        //    }
        //    public string getNameColor()
        //    {
        //        return name_color;
        //    }
        //}

        int is_free(ref Storage storage,int X, int Y)//Проверка на "свободность" места на полотне
        {
            for (int i = 0; i < storage.Occupied(count_cells); ++i)
            {//Проходимся по всему хранилищу
                if ((storage.objects[i] as Circle) != null)//Если это круг
                {
                    Circle c = storage.objects[i] as Circle;
                    if (((X - c.x - c.move / 2) * (X - c.x - c.move / 2) + (Y - c.y - c.move / 2) * (Y - c.y - c.move / 2)) < (c.move / 2) * (c.move / 2))
                        return i;
                }
                if((storage.objects[i] as Triangle) != null)//Если треугольник
                {
                    Triangle t = storage.objects[i] as Triangle;
                    int a = (t.x1-X) * (t.y2 - t.y1) - (t.x2 - t.x1) * (t.y1 - Y);
                    int b = (t.x2 - X) * (t.y3 - t.y2) - (t.x3 - t.x2) * (t.y2 - Y);
                    int c = (t.x3 - X) * (t.y1 - t.y3) - (t.x1 - t.x3) * (t.y3 - Y);
                    if (((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0)))
                        return i;
                }
                if ((storage.objects[i] as Square) != null)//Если квадрат
                {
                    Square s = storage.objects[i] as Square;
                    if (X > s.x1 && Y < s.y1 && X < s.x3 && Y > s.y3)
                        return i;
                }
            }
            return -1;
        }
        void draw_figure(Shape _object)
        {
            if (_object.IsSelected())
                pen.Color = selected_color;
            else
                pen.Color = _object.GetColor();
            if((_object as Circle) != null)
            {
                Circle c = _object as Circle;
                Canvas_Panel.CreateGraphics().DrawEllipse(pen,
                                              c.x,
                                              c.y,
                                              c.move,
                                              c.move);
            }
            if((_object as Triangle) != null)
            {
                Triangle t = _object as Triangle;
                points[0].X = t.x1; points[0].Y = t.y1;
                points[1].X = t.x2; points[1].Y = t.y2;
                points[2].X = t.x3; points[2].Y = t.y3;
                Canvas_Panel.CreateGraphics().DrawPolygon(pen, points);
            }
            if ((_object as Square) != null)
            {
                Square s = _object as Square;
                Canvas_Panel.CreateGraphics().DrawRectangle(pen, s.x4, s.y4, s.move, s.move);
            }
        }
        void deselect(ref Storage storage)
        {
            for (int i = 0; i < count_elements; ++i)
                if (storage.objects[i].IsSelected())
                    storage.objects[i].Select(false);
        }

        string figure_now = "Круг";
        static int count_cells = 5; // Кол-во ячеек в хранилище
        int indexin = 0; // Индекс, в какое место был помещён круг
        int count_elements = 0;
        int now_position = 0;
        Storage storage = new Storage(count_cells);
        Point[] points = new Point[3];
        static Color default_color = Color.Black;
        static Color selected_color = Color.Cyan;
        Pen pen = new Pen(default_color, 3);
        Shape shape = new Shape();
        private void Canvas_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Canvas_Panel.Focus();
            int ind = is_free(ref storage, e.X, e.Y);
            if (e.Button == MouseButtons.Left)
            {
                if (count_elements == count_cells)
                    // Увеличиваем хранилище
                    storage.Increase_Storage(ref count_cells);
                
                switch (figure_now)
                {
                    case "Круг":
                        shape = new Circle(e.X, e.Y);
                        break;
                    case "Треугольник":
                        shape = new Triangle(e.X, e.Y);
                        break;
                    case "Квадрат":
                        shape = new Square(e.X, e.Y);
                        break;
                }
                if (ind == -1)
                {
                    deselect(ref storage);
                    Redrawing_figures(ref storage);
                    storage.Add_object(count_elements, ref shape, count_cells, ref indexin);
                    shape.Select(true);
                    draw_figure(shape);
                    shape.Select(false);
                    count_elements++;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (ind != -1)
                {
                    storage.objects[ind].Select(true);
                    Redrawing_figures(ref storage);
                    if (Control.ModifierKeys == Keys.Control)
                        Redrawing_figures(ref storage);
                    else
                    {
                        deselect(ref storage);

                        storage.objects[ind].Select(true);
                        Redrawing_figures(ref storage);
                    }
                }

            }
            
        }
        //public void updateFromMVC(object sender, EventArgs e)
        //{
        //    pen.Color = model.getColor();
        //    Color back_color = Color.Transparent;
        //    Color selected_back_color = Color.LightPink;
        //    Red_toolStripButton.BackColor = back_color;
        //    Green_toolStripButton.BackColor = back_color;
        //    Blue_toolStripButton.BackColor = back_color;
        //    switch(model.getNameColor())
        //    {
        //        case "Красный":
        //            Red_toolStripButton.BackColor = selected_back_color;
        //            break;
        //        case "Зеленый":
        //            Green_toolStripButton.BackColor = selected_back_color;
        //            break;
        //        case "Синий":
        //            Blue_toolStripButton.BackColor = selected_back_color;
        //            break;
        //    }
        //}

        private void Redrawing_figures(ref Storage storage)
        {
            Canvas_Panel.Refresh();
            for (int i = 0; i < storage.Occupied(count_cells); ++i)
                draw_figure(storage.objects[i]);
        }
        private void Figure_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            figure_now = Figure_toolStripComboBox.SelectedItem.ToString();
            
        }
        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Canvas_Panel.Refresh();
            for (int i = 0; i < count_cells; ++i)
                storage.Delete_object(ref i); // Удаляем объект из хранилища
            count_elements = 0; // Кол-во элементов в хранилище обнуляем 
        }
        private void Red_toolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count_elements; ++i)
                if (storage.objects[i].IsSelected())
                {
                    storage.objects[i].SetColor(Color.Red);
                    //storage.objects[i].Select(false);
                    Redrawing_figures(ref storage);
                    //storage.objects[i].Select(true);
                }
            //model.setColor(Color.Red, "Красный");
        }

        private void Green_toolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count_elements; ++i)
                if (storage.objects[i].IsSelected())
                {
                    storage.objects[i].SetColor(Color.Green);
                    //storage.objects[i].Select(false);
                    Redrawing_figures(ref storage);
                    //storage.objects[i].Select(true);
                }
            //model.setColor(Color.Green, "Зеленый");
        }

        private void Blue_toolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count_elements; ++i)
                if (storage.objects[i].IsSelected())
                {
                    storage.objects[i].SetColor(Color.Blue);
                    storage.objects[i].Select(false);
                    Redrawing_figures(ref storage);
                    //storage.objects[i].Select(true);
                }
            //model.setColor(Color.Blue, "Синий");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < count_elements; ++i)
                    if (storage.objects[i].IsSelected())
                        storage.Delete_object(ref i);
                Redrawing_figures(ref storage);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < count_elements; ++i)
                    if (storage.objects[i].IsSelected())
                        storage.Delete_object(ref i);
                Redrawing_figures(ref storage);
            }
        }
    }
}
