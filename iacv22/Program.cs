using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iacv22
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static class Data
    {
        // предопределенные массивы (словари)
        public static string[] arr_status = new string[] { "Чайник", "Любитель", "Новичок", "Программист", "Почти хакер", "Хакер", "Администратор", "Профессионал", "Сверх" };
        public static string[] arr_job = new string[] { "Пока нет", "Грузчик", "Таксист", "Садовник", "Нач. прогр.", "Программист", "Провайдер", "Вебмастер", "Хакер", "Граф. дизайнер", "Комп. президент" };
        public static string[] arr_english = new string[] { "Не знаю", "1 уровень", "2 уровень", "3 уровень", "4 уровень", "5 уровень", "6 уровень", "7 уровень", "8 уровень" };
        public static string[] arr_education = new string[] { "Начальное", "Неполное", "Среднее", "Неполное", "Высшее" };
        public static string[] arr_furniture = new string[] { "Пока нет", "Подержанная", "Дачная", "ДСП", "Ламинированная", "Офисная", "Элитная" };
        public static string[] arr_kitchen = new string[] { "Пока нет", "Маленькая", "Оборудованная", "Комфортная", "Сверхкомфотная" };
        public static string[] arr_bathroom = new string[] { "Пока нет", "Ведро", "Стандартная", "Джакузи", "Бассейн" };
        public static string[] arr_clothes = new string[] { "Дряхлая", "Спорт.костюм", "Летняя", "Джинсы", "Костюм", "Куртка", "Рубашка", "Футболка и т.д.", "Посл.моды" };
        public static string[] arr_clothes_long = new string[] { "дешевый спортивный костюм", "летнюю одежду", "новые джинсы и футболку", "костюм (брюки и пиджак)", "куртку", "красивую рубашку и брюки", "супер футболку, шорты, кепку и т.д.", "одежду последней моды" };
        public static string[] arr_car = new string[] { "Нет машины", "Пятерка 2105", "Девятка 21093", "Десятка 2110", "Волга 3110", "Mercedes" };
        public static string[] arr_monitor = new string[] { "Пока нет", "14\"", "15\"", "17\"" };
        public static string[] arr_printer = new string[] { "Пока нет", "матричный", "струйный", "лазерный" };
        public static string[] arr_scanner = new string[] { "Пока нет", "ручной", "планшетный" };
        public static string[] arr_modem = new string[] { "Пока нет", "36.6", "56K", "V90" };
        public static string[] arr_cpu = new string[] { "Пока нет", "Intel 486", "Pentium 166", "Pentium 233 MMX", "Pentium II 650", "Pentium III 800", "Pentium IV 1700" };
        public static string[] arr_hdd = new string[] { "Пока нет", "10 Gb", "20 Gb", "30 Gb", "40 Gb", "50 Gb", "60 Gb" };
        public static string[] arr_cd_rom = new string[] { "Пока нет", "16xSpeed", "32xSpeed", "40xSpeed", "48xSpeed", "56xSpeed" };
        public static string[] arr_ram = new string[] { "Пока нет", "32Mb", "64Mb", "128Mb", "256Mb", "512Mb" };
        public static string[] arr_audiocard = new string[] { "Пока нет", "16 KHZ", "22 KHZ", "44 KHZ" };
        public static string[] arr_videocard = new string[] { "Пока нет", "8Mb S3 Savage 4", "16Mb RivaTNT", "32Mb Geforce2", "64Mb Geforce2 MX" };
        public static string[] arr_os = new string[] { "Пока нет", "NC", "W3.11", "W95", "W98", "W2000" };
        public static string[] arr_programming = new string[] { "Пока нет", "Basic", "Pascal", "VB", "VC++" };
        public static string[] arr_graphics = new string[] { "Пока нет", "Corel Xara", "Photoshop", "3D StMax II", "3D StMax III" };
        public static string[] arr_antivirus = new string[] { "Пока нет", "Касперского", "IVP 100" };
        public static string[] arr_hacking = new string[] { "Это очень простое задание. Нужно просто взломать программу. Плата за выполнение 4$.", 
                                                            "Вам необходимо взломать защиту сервера и скачать файл из интернета. Плата за выполнение 5$.",
                                                            "Вам нужно поразить вирусами компьютеры крупной компании. Плата за выполнение 6$.",
                                                            "Вам нужно форматнуть диски банковской системы. Плата за выполнение 7$.",
                                                            "Вам требуется перечислить деньги из маленького магазина себе на счет. Плата за выполнение 8$.", 
                                                            "Вам надо скачать базу данных с банковского компьютера. Плата за выполнение 9$.",
                                                            "Вам требуется перечислить деньги со счета в банке. Плата за выполнение 10$.",
                                                            "Вам требуется удалить спец файл с главного компьютера города. Плата за выполнение 11$.",
                                                            "Это очень сложное задание. Вам требуется скачать себе программу обороны. Плата за выполнение 12$."};

        // соответствие з/п и цен
        public static byte[] cost_job = new byte[] { 0, 10, 20, 25, 30, 35, 40, 45, 50, 55, 70 };
        public static byte[] cost_flat = new byte[] { 30, 45, 60, 80, 95, 150 };
        public static byte[] cost_furniture = new byte[] { 15, 25, 30, 40, 55, 70 };
        public static byte[] cost_kitchen = new byte[] { 10, 15, 20, 40 };
        public static byte[] cost_bathroom = new byte[] { 5, 15, 20, 30 };
        public static byte[] cost_clothes = new byte[] { 5, 10, 15, 20, 25, 30, 30, 35 };
        public static byte[] cost_car = new byte[] { 30, 60, 70, 80, 200 };
        public static byte[] cost_monitor = new byte[] { 15, 30, 45 };
        public static byte[] cost_printer = new byte[] { 10, 30, 40 };
        public static byte[] cost_scanner = new byte[] { 20, 30 };
        public static byte[] cost_modem = new byte[] { 10, 15, 20 };
        public static byte[] cost_cpu = new byte[] { 15, 20, 30, 45, 55, 70 };
        public static byte[] cost_hdd = new byte[] { 10, 15, 20, 30, 40, 50 };
        public static byte[] cost_cd_rom = new byte[] { 10, 15, 20, 30, 40 };
        public static byte[] cost_ram = new byte[] { 10, 15, 20, 30, 40 };
        public static byte[] cost_audiocard = new byte[] { 10, 20, 30 };
        public static byte[] cost_videocard = new byte[] { 10, 20, 30, 70 };
        public static byte[] cost_os = new byte[] { 3, 8, 10, 17, 25 };
        public static byte[] cost_programming = new byte[] { 5, 7, 15, 20 };
        public static byte[] cost_graphics = new byte[] { 4, 10, 15, 25 };
        public static byte[] cost_antivirus = new byte[] { 5, 20 };

        // храним значения переменных на главной форме. Всё это будут цифры
        public static int money = 170;
        public static byte status = 0;
        public static byte job = 0;
        public static int mood = 30;
        public static int hungry = 30;

        public static byte education = 0;
        public static byte english = 0;

        public static byte sch_points = 0;
        public static byte eng_points = 0;
        public static byte com_points = 0;

        public static byte rooms = 1;
        public static byte furniture = 0;
        public static byte kitchen = 0;
        public static byte bathroom = 0;
        public static byte clothes = 0;
        public static byte car = 0;

        public static byte monitor = 0;
        public static byte printer = 0;
        public static byte scanner = 0;
        public static byte modem = 0;
        public static byte cpu = 0;
        public static byte hdd = 0;
        public static byte cd_rom = 0;
        public static byte ram = 0;
        public static byte audiocard = 0;
        public static byte videocard = 0;

        public static byte os = 0;
        public static byte programming = 0;
        public static byte graphics = 0;
        public static byte antivirus = 0;

        public static bool ie = false;
        public static bool dialer = false;
        public static bool downloader = false;
        public static bool internet_access = false;
        public static bool anecdotes = false;

        public static bool school = false;
        public static bool eng_course = false;
        public static bool com_course = false;

        // прочее пошли
        public static int account = 0;

        public static bool snasti = false;
        public static bool udochka = false;
        public static int prikormka = 0;
        public static int fishes = 0;

        public static bool show_win = false;
    }
}
