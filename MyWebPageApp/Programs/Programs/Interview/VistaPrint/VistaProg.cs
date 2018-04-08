using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs.Interview.VistaPrint
{
    public class SolutionF
    {
        public class PhoneCall
        {
            public long phoneNumber { get; set; }
            public int totalDuration { get; set; } //Seconds
            public int totalBill { get; set; }
        }

        public int solution(String S)
        {

            String[] phoneCalls = S.Split((char)10);

            var PhoneCall_dict = new Dictionary<long, PhoneCall>();

            // maxiumum duraction call
            PhoneCall maxDurationphoneCall = null;
            
            int totalPhoneBill = 0;

            foreach (var phoneCall in phoneCalls)
            {
                var phoneInfo = phoneCall.Split(',');
                var duration = phoneInfo[0].Trim();
                var phone = phoneInfo[1].Trim();

                var NumericPhone = ConvertPhoneToNumeric(phone);

                PhoneCall phoneObj = null;

                if (!PhoneCall_dict.ContainsKey(NumericPhone))
                {
                    phoneObj = new PhoneCall() { phoneNumber = NumericPhone, totalDuration = CalcDurationInSec(duration), totalBill = CalcBill(duration) };
                    PhoneCall_dict.Add(phoneObj.phoneNumber, phoneObj);
                }
                else
                {
                    phoneObj = PhoneCall_dict[NumericPhone];
                    phoneObj.totalDuration += CalcDurationInSec(duration);
                    phoneObj.totalBill += CalcBill(duration);
                }

                totalPhoneBill += CalcBill(duration);

                // Check for Tie cases
                if (maxDurationphoneCall == null) // First time
                    maxDurationphoneCall = phoneObj;
                else if(maxDurationphoneCall.totalDuration <= phoneObj.totalDuration)
                {
                    if (maxDurationphoneCall.totalDuration < phoneObj.totalDuration)
                    {
                        maxDurationphoneCall = phoneObj; 
                    }
                    else
                    {
                        //check for smallest numbr
                        maxDurationphoneCall = (maxDurationphoneCall.phoneNumber < phoneObj.phoneNumber) ? maxDurationphoneCall : phoneObj;
                    }
                }     
            }

            return totalPhoneBill - maxDurationphoneCall.totalBill;
        }

        private long ConvertPhoneToNumeric(String phone)
        {
            StringBuilder sb = new StringBuilder();

            var phoneDigits = phone.Split('-');

            foreach(var digit in phoneDigits)
            {
                sb.Append(digit.Trim());
            }
            return long.Parse(sb.ToString());
        }

        private int CalcDurationInSec(string duration)
        {
            var timeInfo = duration.Split(':');

            var hr = timeInfo[0].Trim();
            var min = timeInfo[1].Trim();
            var sec = timeInfo[2].Trim(); 

            //convert into seconds
            var totalSec = int.Parse(hr) * 60 * 60 + int.Parse(min) * 60 + int.Parse(sec);

            return totalSec;
        }

        private int CalcBill(string duration)
        {
           var totalSec = CalcDurationInSec(duration);

            if (totalSec < 5 * 60)
            {
                return totalSec * 3;
            }
            else
            {
                var minutes = totalSec / 60;

                if (totalSec % 60 == 0)
                    return minutes * 150;
                else
                    return ((minutes + 1) * 150);
            }
        }
    }
}
