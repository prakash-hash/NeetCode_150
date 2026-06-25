public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {

        int n = position.Length;

        var cars = new (int pos, double time)[n];

        for (int i = 0; i < n; i++) {
            cars[i] = (
                position[i],
                (double)(target - position[i]) / speed[i]
            );
        }

        Array.Sort(cars, (a, b) => b.pos.CompareTo(a.pos));

        int fleets = 0;
        double maxTime = 0;

        foreach (var car in cars) {
            if (car.time > maxTime) {
                fleets++;
                maxTime = car.time;
            }
        }

        return fleets;
    }
}