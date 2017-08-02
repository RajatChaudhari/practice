using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class AddLinkedList
    {
        public ListNode Add2Numbers(ListNode l1, ListNode l2)
        {

            ListNode l3 = new ListNode(0);
            ListNode l4 = l3;
            int carry = 0;
            while (l1 != null || l2 != null)
            {

                int a = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
                carry = a / 10;
                a = a % 10;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                l4.next = new ListNode(a);
                l4 = l4.next;
            }
            if (carry > 0)
            {
                l4.next = new ListNode(carry);
            }
            return l3.next;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }

        //public static void Main(string[] args)
        //{
        //    AddLinkedList call = new AddLinkedList();
        //    ListNode l1 = new ListNode(Convert.ToInt32(Console.ReadLine()));
        //    ListNode l2 = new ListNode(Convert.ToInt32(Console.ReadLine()));
        //    call.AddTwoNumbers(l1, l2);
        //}
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
