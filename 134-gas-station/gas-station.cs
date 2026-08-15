public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if(gas.Sum() < cost.Sum()){
            return -1;
        }
        // int[] dif = new int[gas.Length];
        // for(int i = 0; i < gas.Length; i++){
        //     dif[i] = gas[i] - cost[i];
        // }
            int total_cost = 0;
            int starting = 0;
        for(int j =0 ; j < gas.Length; j++){
           // total_cost+=dif[j];
             total_cost+= (gas[j] - cost[j]);
            if(total_cost < 0){
                total_cost = 0;
                starting =  j+1;
            }
        }
        return starting;
    }
}