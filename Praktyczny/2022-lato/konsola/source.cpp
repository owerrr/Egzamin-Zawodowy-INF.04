#include <iostream>

class Osoba {
private:
	int id;
	std::string imie;
	static int liczbaOsob;
public:
	Osoba() {
		this->id = 0;
		this->imie = "";
		liczbaOsob++;
	}
	Osoba(int id, std::string imie) {
		this->id = id;
		this->imie = imie;
		liczbaOsob++;
	}
	Osoba(Osoba& osoba) {
		this->id = osoba.id;
		this->imie = osoba.imie;
		liczbaOsob++;
	}

	void writeName(Osoba& osoba){
		std::cout << "czesc " << osoba.imie << ", mam na imie " << this->imie;
	}

};

int Osoba::liczbaOsob = 0;

int main()
{
	Osoba os1(1, "Andrzej");
	Osoba os2(2, "Michael");
	os1.writeName(os2);
	return 0;
}
