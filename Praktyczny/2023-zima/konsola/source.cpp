#include <iostream>

class Note {
private:
	static int noteCount;
	int id;
protected:
	std::string title;
	std::string content;
public:
	Note(std::string title, std::string content) {
		this->title = title;
		this->content = content;
		noteCount++;
		this->id = noteCount;
	}

	void showNote() {
		std::cout << "Tytul notatki: " << this->title << std::endl;
		std::cout << "Tresc: " << this->content << std::endl;
	}

	void noteDetails() {
		std::cout << noteCount << ";" << id << ";" << title << ";" << content << std::endl;
	}
};

int Note::noteCount = 0;

int main()
{
	Note n1("Nieznana", "jakas dziwna notatka");
	Note n2("Poznana", "poznan to miasto doznan jak to powiadali.");
	Note n3("Hej", "to tyle wsm");
	n2.showNote();
	n1.noteDetails();
	return 0;
}
