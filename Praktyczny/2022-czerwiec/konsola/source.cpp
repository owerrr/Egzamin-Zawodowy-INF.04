#include <iostream>
#include <cstdlib>

class Array {
private:
	static const int MAX_SIZE = 50;
	int randomNumbers[MAX_SIZE+1] = { };
public:
	void fillArray() {
		srand(time(NULL));
		for (int i = 0; i < MAX_SIZE; i++) {
			int random = rand() % 101;
			randomNumbers[i] = random;
		}
	}

	void showArray() {
		std::cout << "Liczby zapisane w tablicy: \n";
		for (int i = 0; i < MAX_SIZE + 1; i++) {
			std::cout << randomNumbers[i];
			if (i < MAX_SIZE) std::cout << ", ";
		}
		std::cout << std::endl;
	}

	int findNumber(int numberToFind) {
		randomNumbers[MAX_SIZE] = numberToFind;
		for (int i = 0; i < MAX_SIZE + 1; i++) {
			if (randomNumbers[i] == numberToFind) return i;
		}
	}
};

int main()
{
	Array a1 = Array();
	a1.fillArray();
	a1.showArray();
	std::cout << "Podaj liczbe do wyszukania: ";
	int numberToFind; std::cin >> numberToFind;
	std::cout << "Znaleziono liczbe " << numberToFind << " na pozycji: " << a1.findNumber(numberToFind) << std::endl;
	a1.showArray();
	return 0;
}
