#include <iostream>
static const int MAX_SIZE = 100;


int main()
{
	bool A[MAX_SIZE];
	for (int i = 0; i < MAX_SIZE; i++) {
		A[i] = 1;
	}
	for (int i = 2; i * i < MAX_SIZE; i++) {
		if (A[i]) {
			for (int j = i * i; j < MAX_SIZE; j += i) {
				A[j] = 0;
			}
		}
	}

	for (int i = 0; i < MAX_SIZE; i++) {
		if (A[i]) std::cout << i << std::endl;
	}
	return 0;
}
