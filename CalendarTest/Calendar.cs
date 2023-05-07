using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarTest
{
    public partial class Calendar : Form
    {
        public static Form Form1;      
        private DateTime CurrentDate = DateTime.Now;
        System.Windows.Forms.Label[] Days = new System.Windows.Forms.Label[42];

        public Calendar()
        {
            InitializeComponent();
            SettingDays();
            SetDate(CurrentDate);
        }       

        public void Btnerror(string ErrorMassage)
        {
            MessageBox.Show(ErrorMassage);
        }

        private void SettingDays()
        {
            for (int i = 0; i < Days.Length; i++)
            {
                Days[i] = Controls.Find($"day{i + 1}", true).FirstOrDefault() as System.Windows.Forms.Label;
                if (Days[i] == null)
                {
                    Days[i] = new System.Windows.Forms.Label();
                }
            }
        }

        private void SetCurrentDate(DateTime Date)
        {
            string CurrentMonth = Date.Month.ToString();
            string CurrentYear = Date.Year.ToString();
            MonthLabel.Text = CurrentMonth + "월";
            YearLabel.Text = CurrentYear + "년";
            CurrentDate = Date;
        }

        public DateTime ToSolarDate(int LunarYear, int LunarMonth, int LunarDay)
        {
            System.Globalization.KoreanLunisolarCalendar LunarCalendar = new System.Globalization.KoreanLunisolarCalendar();
            bool isLeapMonth = LunarCalendar.IsLeapMonth(LunarYear, LunarMonth);
            int LeapMonthCount;

            if (LunarCalendar.GetMonthsInYear(LunarYear) > 12)
            {
                LeapMonthCount = LunarCalendar.GetLeapMonth(LunarYear);
                if (isLeapMonth)
                    LunarMonth++;
                if (LunarMonth > LeapMonthCount)
                    LunarMonth++;
            }
            try
            {
                LunarCalendar.ToDateTime(LunarYear, LunarMonth, LunarDay, 0, 0, 0, 0);
            }
            catch
            {
                return LunarCalendar.ToDateTime(LunarYear, LunarMonth, LunarCalendar.GetDaysInMonth(LunarYear, LunarMonth), 0, 0, 0, 0);
            }
            return LunarCalendar.ToDateTime(LunarYear, LunarMonth, LunarDay, 0, 0, 0, 0);
        }

        private Dictionary<int, List<string>> SettingLunarHoliday(DateTime dateTime, DateTime SelectedDate, Dictionary<int, List<string>> HolidayDate, string Holiday)
        {
            if (dateTime.Month == SelectedDate.Month)
            {
                if(HolidayDate.ContainsKey(dateTime.Day))
                    HolidayDate[dateTime.Day].Add(Holiday);

                else
                    HolidayDate.Add(dateTime.Day,new List<string> { Holiday });
            }
            return HolidayDate;
        }

        private Dictionary<int, List<string>> GetHoliday(DateTime SelectedDate)
        {
            Dictionary<int, List<string>> HolidayDate = new Dictionary<int, List<string>>();
            switch (SelectedDate.Month)
            {
                case 1:
                    HolidayDate.Add(1, new List<string> { "신정" });
                    break;

                case 3:
                    HolidayDate.Add(1, new List<string> { "삼일절" });
                    break;

                case 5:
                    HolidayDate.Add(5, new List<string> { "어린이날" });
                    break;

                case 6:
                    HolidayDate.Add(6, new List<string> { "현충일" });
                    break;

                case 8:
                    HolidayDate.Add(15, new List<string> { "광복절" });
                    break;

                case 10:
                    HolidayDate.Add(3, new List<string> { "개천절" });
                    HolidayDate.Add(9, new List<string> { "한글날" });
                    break;

                case 12:
                    HolidayDate.Add(25, new List<string> { "크리스마스" });
                    break;

                default:
                    break;
            }

            DateTime HdateTime = new DateTime(SelectedDate.Year - 1, 12, 30);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "까치 설날");
            HdateTime = new DateTime(SelectedDate.Year, 1, 1);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "설날");
            HdateTime = new DateTime(SelectedDate.Year, 1, 2);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "설 다음날");

            HdateTime = new DateTime(SelectedDate.Year, 4, 8);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "석가탄신일");

            HdateTime = new DateTime(SelectedDate.Year, 8, 14);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "추석 전날");
            HdateTime = new DateTime(SelectedDate.Year, 8, 15);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "추석");
            HdateTime = new DateTime(SelectedDate.Year, 8, 16);
            HdateTime = ToSolarDate(HdateTime.Year, HdateTime.Month, HdateTime.Day);
            HolidayDate = SettingLunarHoliday(HdateTime, SelectedDate, HolidayDate, "추석 다음날");

            return HolidayDate;
        }

        private void SetDate(DateTime Date)
        {
            SetCurrentDate(Date);

            Dictionary<int, List<string>> Holiday = GetHoliday(Date);
            DateTime StartDay = new DateTime(Date.Year, Date.Month, 1);
            int EndDay = DateTime.DaysInMonth(Date.Year, Date.Month);
            int StartDayWeek = (int)StartDay.DayOfWeek;

            for (int i = 1; i <= EndDay; i++)
            {
                int index = i + StartDayWeek - 1;
                Days[index].Text = i.ToString();

                if (Holiday != null && Holiday.ContainsKey(i))
                {
                    Days[index].ForeColor = Color.Red;
                    for (int j = 0; j < Holiday[i].Count; j++)
                        Days[index].Text += "\n" + Holiday[i][j];
                }
                else
                {
                    if (index % 7 == 0)
                        Days[index].ForeColor = Color.Red;

                    else if (index % 7 == 6)
                        Days[index].ForeColor = Color.Blue;

                    else
                        Days[index].ForeColor = Color.Black;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ClearDate()
        {
            for (int i = 0; i < Days.Length; i++)
            {
                Days[i].BorderStyle = BorderStyle.None;
                Days[i].ForeColor = Color.Black;
                Days[i].BackColor = Color.White;
                Days[i].Text = string.Empty;
            }
        }

        private void Before_Btn_Click(object sender, EventArgs e)
        {
            DateTime PreviousMonthDate = CurrentDate.AddMonths(-1);
            ClearDate();
            SetDate(PreviousMonthDate);
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            DateTime NextMonthDate = CurrentDate.AddMonths(1);
            ClearDate();
            SetDate(NextMonthDate);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Date = new DateTime(int.Parse(SearchYear.Text), SearchMonth.SelectedIndex + 1, 1);
                ClearDate();
                SetDate(Date);
            }
            catch(Exception err)
            {
                Btnerror(err.Message);
            }
        }
    }
}
