#include <iostream>

void Euklides(int a, int b) {
	while (a != b) {
		if (a > b) {
			a -= b;
		}
		else {
			b -= a;
		}
	}
	std::cout << a;
}

int main()
{
	int a, b;
	do {
		std::cout << "Podaj a: ";
		std::cin >> a;
		std::cout << "Podaj b: ";
		std::cin >> b;
	} while (a < 0 || b < 0);
	Euklides(a, b);
	return 0;
}
