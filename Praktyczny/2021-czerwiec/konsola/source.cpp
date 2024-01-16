#include <iostream>

class Sort {
private:
    static const int MAX_SIZE = 10;
    int numbers[MAX_SIZE] = {};
    
/*********************************************************
    # nazwa funkcji: getMaxValue
    # parametry wejściowe: -
    # wartość zwracana: 
        - max -> maksymalną liczbę z tablicy numbers
    # autor: xyz
*********************************************************/
    int getMaxValue() {
        int max = numbers[0];
        for (int i = 0; i < MAX_SIZE; i++) {
            if (max < numbers[i]) max = numbers[i];
        }
        return max;
    }
public:
/*********************************************************
    # nazwa funkcji: fillArray()
    # parametry wejściowe: -
    # wartość zwracana: -
    # autor: xyz
*********************************************************/
    void fillArray() {
        int temp;
        std::cout << "UWAGA! Teraz wypelnisz tablice kolejno 10 liczbami calkowitymi.\n";
        for (int i = 0; i < MAX_SIZE; i++) {
            std::cout << i + 1 << " liczba: "; 
            std::cin >> temp;
            numbers[i] = temp;
        }
    }

/*********************************************************
    # nazwa funkcji: showArray()
    # parametry wejściowe: -
    # wartość zwracana: -
    # autor: xyz
*********************************************************/
    void showArray() {
        for (int i = 0; i < MAX_SIZE; i++) {
            std::cout << numbers[i];
            if (i < 9)
                std::cout << ", ";
            else
                std::cout << "\n";
        }
    }
/*********************************************************
        # nazwa funkcji: getMaxValue
        # parametry wejściowe: -
        # wartość zwracana: -
        # autor: xyz
 *********************************************************/
    void sortBySelection() {
        for (int i = 0; i < MAX_SIZE; i++) {
            int min = numbers[i];
            for (int j = i; j < MAX_SIZE; j++) {
                if (min > numbers[j]) {
                    min = numbers[j];
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers [j] = temp;
                }
            }
        }
    }
};

int main()
{
    Sort s1 = Sort();
    s1.fillArray();
    s1.showArray();
    s1.sortBySelection();
    s1.showArray();
}
