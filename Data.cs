struct Factor_p
{
    public string name;
    public bool v_up;
    public decimal value;
}
struct Factor_med
{
    public string name;
    public int sick;
    public int sick_time;
    public decimal die;
}

namespace Maket_PZ
{
    static class Data
    {
        public static Factor_p[] Factor_p = new Factor_p[100];
        public static Factor_med[] Factor_med = new Factor_med[100];
        public static int p_factor_count;
        public static int med_factor_count;
        public static bool close_menu_p = true;
        public static bool close_menu_med = true;
    }
}
