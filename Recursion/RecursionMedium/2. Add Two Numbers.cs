using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMedium
{
    public static class _2AddTwoNumbers
    {
        public static ListNode AddTwoNumber(ListNode l1, ListNode l2)
        {
            return AddNum(l1, l2 , 0);
        }

        private static ListNode AddNum(ListNode l1, ListNode l2, int carry)
        {
            int value;
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }
            int x = l1 != null ? l1.value : 0;
            int y = l2 != null ? l2.value : 0;
            ListNode x1 = l1 != null ? l1.next : null;
            ListNode x2 = l2 != null ? l2.next : null;
            int sum = x + y + carry;
            value = sum % 10;
            carry = sum / 10;
            return new ListNode(value, AddNum(x1, x2, carry));            
        }        
    }
}
