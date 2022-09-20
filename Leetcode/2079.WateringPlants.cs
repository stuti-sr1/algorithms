using System;
public class WateringPlantsSolution {
    public static int WateringPlants(int[] plants, int capacity) {
        int i=0, step=0,currentcapacity=capacity;
        bool flag=true;        
        while(i<plants.Length)
        {
            if(currentcapacity >= plants[i])
            {
                if(flag){
                    step+=1;
                }
                else{
                    step+=i+1;
                    flag=!flag;
                }
                currentcapacity-=plants[i];
                i++;
            }
            else 
            {
                step+=i;                
                currentcapacity=capacity;
                flag=false;
            }
        }
        return step;
    }
}

// int i=0, step=0,currentcapacity=capacity;      
//         while(i<plants.Length)
//         {
//             if(currentcapacity >= plants[i])
//             {
//                 step+=1;
//                 currentcapacity-=plants[i];
//             }
//             else 
//             {
//                 step+=2*i+1;                
//                 currentcapacity=(capacity - plants[i]);
//             }
//             i++;
//         }
//         return step;