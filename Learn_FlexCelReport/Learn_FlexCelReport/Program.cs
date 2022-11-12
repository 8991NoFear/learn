using FlexCel.Report;
using FlexCel.XlsAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_FlexCelReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var dsDoiTuong = _GetDSDoiTuong();
            using (var fr = new FlexCelReport(aAllowOverwritingFiles: false))
            {
                var xls = new XlsFile(aAllowOverwritingFiles: true);
                var templatePath = @"C:\Users\ANONYMOUS\Desktop\learn\Learn_FlexCelReport\Learn_FlexCelReport\Templates\BAO_CAO.xlsx";
                var reportPath = @"C:\Users\ANONYMOUS\Desktop\learn\Learn_FlexCelReport\Learn_FlexCelReport\Templates\BAO_CAO_RESULT.xlsx";
                try
                {
                    xls.Open(templatePath);
                    fr.AddTable("DOI_TUONGs", dsDoiTuong);
                    fr.Run(xls);
                    xls.Save(reportPath);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        public static IList<DOI_TUONG> _GetDSDoiTuong()
        {
            return new List<DOI_TUONG>() {
                new DOI_TUONG()
                {
                    HO_TEN = "BinhLD",
                    GIOI_TINH = 0,
                    MUI_TIEMs = new List<MUI_TIEM>()
                    {
                        new MUI_TIEM() {SO_THU_TU_MUI = 1, TEN_VACXIN = "Pfizer"},
                    }
                },
                new DOI_TUONG()
                {
                    HO_TEN = "DucVV",
                    GIOI_TINH = 0,
                    MUI_TIEMs = new List<MUI_TIEM>()
                    {
                        new MUI_TIEM() {SO_THU_TU_MUI = 1, TEN_VACXIN = "Verocel"},
                        new MUI_TIEM() {SO_THU_TU_MUI = 2, TEN_VACXIN = "Verocel"},
                    }
                },
            };
        }
    }
}
