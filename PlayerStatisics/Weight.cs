namespace PlayerStatisics
{
    public class Weight
    {
        public string CalculateLoad(int strScore, decimal load)
        {
            const string lig = "Light";
            const string med = "Medium";
            const string hev = "Heavy";
            const string over = "Overload";
            const string err = "Error";
            
            switch (strScore)
            {
                case 1:
                    if (load <= 3) return lig;
                    if (load <= 6) return med;
                    if (load <= 10) return hev;
                    return over;
                case 2:
                    if (load <= 6) return lig;
                    if (load <= 13) return med;
                    if (load <= 20) return hev;
                    return over;
                case 3:
                    if (load <= 10) return lig;
                    if (load <= 20) return med;
                    if (load <= 30) return hev;
                    return over;
                case 4:
                    if (load <= 13) return lig;
                    if (load <= 26) return med;
                    if (load <= 40) return hev;
                    return over;
                case 5:
                    if (load <= 16) return lig;
                    if (load <= 33) return med;
                    if (load <= 50) return hev;
                    return over;
                case 6:
                    if (load <= 20) return lig;
                    if (load <= 40) return med;
                    if (load <= 60) return hev;
                    return over;
                case 7:
                    if (load <= 23) return lig;
                    if (load <= 46) return med;
                    if (load <= 70) return hev;
                    return over;
                case 8:
                    if (load <= 26) return lig;
                    if (load <= 53) return med;
                    if (load <= 80) return hev;
                    return over;
                case 9:
                    if (load <= 30) return lig;
                    if (load <= 60) return med;
                    if (load <= 90) return hev;
                    return over;
                case 10:
                    if (load <= 33) return lig;
                    if (load <= 66) return med;
                    if (load <= 100)return hev;
                    return over;
                case 11:
                    if (load <= 38) return lig;
                    if (load <= 76) return med;
                    if (load <= 110) return hev;
                    return over;
                case 12:
                    if (load <= 43) return lig;
                    if (load <= 86) return med;
                    if (load <= 130) return hev;
                    return over;
                case 13:
                    if (load <= 50) return lig;
                    if (load <= 100) return med;
                    if (load <= 150) return hev;
                    return over;
                case 14:
                    if (load <= 58) return lig;
                    if (load <= 116) return med;
                    if (load <= 175) return hev;
                    return over;
                case 15:
                    if (load <= 66) return lig;
                    if (load <= 133) return med;
                    if (load <= 200) return hev;
                    return over;
                case 16:
                    if (load <= 76) return lig;
                    if (load <= 153) return med;
                    if (load <= 230) return hev;
                    return over;
                case 17:
                    if (load <= 86) return lig;
                    if (load <= 173) return med;
                    if (load <= 260) return hev;
                    return over;
                case 18:
                    if (load <= 100) return lig;
                    if (load <= 200) return med;
                    if (load <= 300) return hev;
                    return over;
                case 19:
                    if (load <= 116) return lig;
                    if (load <= 233) return med;
                    if (load <= 350) return hev;
                    return over;
                case 20:
                    if (load <= 133) return lig;
                    if (load <= 266) return med;
                    if (load <= 400) return hev;
                    return over;
                case 21:
                    if (load <= 153) return lig;
                    if (load <= 306) return med;
                    if (load <= 460) return hev;
                    return over;
                case 22:
                    if (load <= 173) return lig;
                    if (load <= 346) return med;
                    if (load <= 520) return hev;
                    return over;
                case 23:
                    if (load <= 200) return lig;
                    if (load <= 400) return med;
                    if (load <= 600) return hev;
                    return over;
                case 24:
                    if (load <= 233) return lig;
                    if (load <= 466) return med;
                    if (load <= 700) return hev;
                    return over;
                case 25:
                    if (load <= 266) return lig;
                    if (load <= 533) return med;
                    if (load <= 800) return hev;
                    return over;
                case 26:
                    if (load <= 306) return lig;
                    if (load <= 613) return med;
                    if (load <= 920) return hev;
                    return over;
                case 27:
                    if (load <= 346) return lig;
                    if (load <= 693) return med;
                    if (load <= 1040) return hev;
                    return over;
                case 28:
                    if (load <= 400) return lig;
                    if (load <= 800) return med;
                    if (load <= 1200) return hev;
                    return over;
                case 29:
                    if (load <= 466) return lig;
                    if (load <= 933) return med;
                    if (load <= 1400) return hev;
                    return over;

            }
            return err;
        }
    }
}