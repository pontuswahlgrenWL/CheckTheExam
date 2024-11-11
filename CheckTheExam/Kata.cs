namespace checktheexam;
public class Kata {
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        var points = 0;
        for (int i = 0; i < arr1.Length; i++) {
            if(arr2[i] == "") {
                continue;
            }
            if(arr1[i] == arr2[i]) {
                points += 4;
            } else {
                points -= 1;
            }
        }

        if (points < 0) {
            return 0;
        }

        return points;
    }
}