using System;
using System.IO;
using System.Windows.Forms;

namespace Working_with_flash_drives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Создание переменных;
        public static string FileD { get; set; }
        public static string Type_Of_File { get; set; }
        public static string Name_Disks { get; set; }


        // Метод получения названия внешних дисков для дальнейшей работы с данными;
        private void Search_for_disks_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищение при повторном использование;
                Selecting_a_disk.Items.Clear();
                // Проверка на количество внешних дисков;
                foreach (DriveInfo DriverSearch in DriveInfo.GetDrives()) if (DriverSearch.IsReady && DriverSearch.DriveType == DriveType.Removable) Selecting_a_disk.Items.Add(DriverSearch.Name);
                if (Selecting_a_disk.Items.Count == 0)
                {
                    Selecting_a_disk.Text = null;
                    // Создание ошибки при не обнаружении внешних носителей;
                    throw new Exception();
                }
            }
            // Вывод ошибки при не обнаружении внешних носителей;
            catch (Exception)
            {
                MessageBox.Show(text: "Проверьте правильность подключения внешних носителей.", caption: "Ошибка при поиске внешних носителей", MessageBoxButtons.OK);
            }
        }


        private void Activate_Text_Click(object sender, EventArgs e)
        {
            // Проверка на количество элементов в грубого говоря списке. Если = 0 - ошибка;
            try
            {
                Name_Disks = Selecting_a_disk.SelectedItem.ToString();
                MessageBox.Show(text: $"Вы выбрали диск {Name_Disks}.", caption: "Подтверждение действия", MessageBoxButtons.OK);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(text: "Вы не ввели внешний носитель.", caption: "Ошибка получения имени внешнего носителя", MessageBoxButtons.OK);
            }
        }


        // Определение типов файлов;
        private void Type_of_Files_Click(object sender, EventArgs e)
        {
            // Проверка на ввод типов данных;
            if (Entering_the_type.Text == "")
            {
                MessageBox.Show(text: "Вы не ввели тип файла.", caption: "Ошибка получения типа файла", MessageBoxButtons.OK);
            }
            // Записываем в переменную текст из Entering_the_type;
            else Type_Of_File = Entering_the_type.Text;
            Entering_the_type.Text = null;
        }


        // Открытие и получение основной директории;
        private void Search_Directory_Click(object sender, EventArgs e)
        {
            // Если нажата кнопка выбор папки в в выборе директории, то идет запись;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) FileD = folderBrowserDialog1.SelectedPath + @"\";
            else
            {
                MessageBox.Show(text: "Выберите директорию для перемещение файлов.", caption: "Отмена пользователем", MessageBoxButtons.OK);
                FileD = null;
            }
            // Проверка на правельный выбор директории;
            if (FileD != null)
            {
                if (MessageBox.Show(text: "Вы уверены в правильности выбраной дириктории  для перемещение файлов.", caption: "Подтверждения действия", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show(text: "Выбирите нужную директорию для записи.", caption: "Отмена пользователем", MessageBoxButtons.OK);
                    FileD = null;
                }
            }
        }


        // Перенос файлов с обознчением типа;
        private static void DownloadFilesWithParams()
        {
            int count = 0;
            // Загрузка файлов с определенным типом данных;
            foreach (var temp in new DirectoryInfo(Name_Disks).GetFiles())
            {
                if (Path.GetExtension(temp.Name).Substring(1) == Type_Of_File.ToLower())
                {
                    try
                    {
                        temp.MoveTo($"{FileD} {temp.Name}");
                        count++;
                    }
                    catch
                    {
                        MessageBox.Show(text: $"Файл с названием {temp.Name} уже существует на флешке.", caption: "Ошибка действия", buttons: MessageBoxButtons.OK);
                    }
                }
            }
            // Проверка на количество файлов перекинутых с флешки;
            if (count == 0) MessageBox.Show(text: $"На данном внешнем диске нету файлов типа {Type_Of_File} для переноса.", caption: "Ответ системы", buttons: MessageBoxButtons.OK);
            else MessageBox.Show(text: $"C вашего диска были переписаны файлы типа {Type_Of_File} в количестве {count}.", caption: "Ответ системы", buttons: MessageBoxButtons.OK);
            Type_Of_File = null;
        }


        // Перенос всех файлов;
        private static void DownloadFilesWithoutParams()
        {
            int count = 0;
            foreach (var MoveFile in new DirectoryInfo(Name_Disks).GetFiles())
            {
                try
                {
                    MoveFile.MoveTo($"{FileD} {MoveFile.Name}");
                    count++;
                }
                catch
                {
                    MessageBox.Show(text: $"Файл с названием {MoveFile.Name} уже существует на флешке.", caption: "Ошибка действия", buttons: MessageBoxButtons.OK);
                }
            }
            if (count == 0) MessageBox.Show(text: $"На данном внешнем диске нету файлов.", caption: "Ответ системы", buttons: MessageBoxButtons.OK);
            else MessageBox.Show(text: $"C вашего диска были переписаны все файлы.", caption: "Ответ системы", buttons: MessageBoxButtons.OK);
        }


        // 
        private void Start_Download_Click(object sender, EventArgs e)
        {
            if (Name_Disks == null || FileD == null) MessageBox.Show(text: "Вы не ввели директорию или имя внешнего носителя для переноса файлов", caption: "Ошибка при переносе файлов", MessageBoxButtons.OK);
            else
            {
                // Проверка пользователем правильности выборанного внешнего диска;
                if (MessageBox.Show(text: $"Вы уверены в правильности выборанного внешних носителей? Вы выбрали внешний носитель {Name_Disks}.", caption: "Подтверждения действия", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        // Проверка выбора типа данных пользователем, вызовы методов;
                        if (Type_Of_File != null)
                        {
                            if (MessageBox.Show(text: $"Вы уверены в правильности выбора типа данных, а именно {Type_Of_File}?", caption: "Подтверждения действия", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                DownloadFilesWithParams();
                            }
                            else MessageBox.Show(text: $"Выберите правельный тип данных.", caption: "Отмена пользователем", buttons: MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (MessageBox.Show(text: "Формат файлов для загрузки не выбран. Хотите загрузить все файлы?", caption: "Подтверждения действия", buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                DownloadFilesWithoutParams();
                            }
                            else MessageBox.Show(text: "Выбирите формат для загрузки файлов.", caption: "Отмена пользователем", buttons: MessageBoxButtons.OK);
                        }
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show(text: "Диск был извлечен или сломан во время попытки переноса файлов.", caption: "Ошибка при получения доступа к внешнему носителей", MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show(text: "Выбирите другой внешний носитель.", caption: "Отмена пользователем", MessageBoxButtons.OK);
            }
        }
    }
}

