using System;

public static class AddTwoNumbersFun {

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head=new ListNode(0);
		ListNode res=head;
		int sum=0,  carry=0, x=0, y=0;
		while(l1!= null || l2!=null || carry!=0)
		{
			x=l1!=null ? l1.val : 0;
            y=l2!=null ? l2.val : 0;
            sum=x+y+carry;
            l1=l1!=null ?l1.next: null;
            l2=l2!=null ?l2.next: null;
			carry=sum/10;	
            res.next =new ListNode(sum%10);  
            res=res.next;
		}
		return head.next;   
    }
    /*
    public static ListNode AddTwoNumbers1(ListNode l1, ListNode l2) {
        ListNode head=new ListNode(0);
		ListNode res=head;
		int sum=0,  val=0,  carry=0;
		while(l1!= null || l2!=null)
		{
			if(l1!= null && l2!=null)
            {
				sum=l1.val+l2.val+carry;
                l1=l1.next;
                l2=l2.next;
            }            
			else if(l1== null && l2!=null)
            {
				sum=l2.val+carry;
                l2=l2.next;
            }
			else 
            {
                sum=l1.val+carry;                
                l1=l1.next;
            }
			val=sum%10;
			carry=sum/10;	
            res.next =new ListNode(val);  
            res=res.next;
		}
        if(carry >0 )
            res.next =new ListNode(carry); 
		return head.next;   
    }
    */

}