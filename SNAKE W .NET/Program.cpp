#include <iostream>
#include <conio.h>
#include <string>
#include <windows.h>
using namespace std;

bool gameover;
bool shutDown;
const int width = 20;
const int height = 20;
int x, y, fruitX, fruitY, score;
int tailX[400], tailY[400], nTail;
enum eDirection { STOP, LEFT, RIGHT, UP, DOWN };
eDirection dir;

void StartScreen()
{
		system("cls");
		cout << "\nWITAJ W SNAKE CONNSOLE!"
			<< "\n\nCzesc, wcisnij 's' zeby zaczynac!"
			<< "\n\nWcisnij 'q' zeby wyjsc."
			<< "\n\nWcisnij 'i' zeby otrzymac instrukcje"
			<< "\n\nTwoj poprzedni wynik: " << score << endl;
}
void Instructions()
{
		system("cls");
		cout << "\n\nUzyj 'w' zeby isc w GÓRĘ."
			<< "\n\nUzyj 'a' zeby isc w LEWO."
			<< "\n\nUzyj 's' zeby isc w DÓŁ."
			<< "\n\nUzyj 'd' zeby isc w PRAWO."
			<< "\n\nWcisnij 'x' kiedykolwiek zeby wyjsc."
			<< "\n\nNIE dotykaj granic bo PRZEGRASZ."
			<< "\n\nNIE zmieniaj kierunku na przeciwny bo PRZEGRASZ."
			<< "\nNIE jedz wlasnego ogona bo rzecz jasna PRZEGRASZ!"
			<< "\n\n\nA teraz wcisnij 'm' zeby wrocic do MENU.\n";
		string input;
		cin >> input;
		if (input == "m")
			StartScreen();
}
void FruitSpawn()
	{
		fruitX = rand() % width;
		fruitY = rand() % height;
}
void Setup()
{
		gameover = false;
		shutDown = false;
		dir = STOP;
		x = width / 2;
		y = height / 2;
		FruitSpawn();
		score = 0;
		nTail = 0;
}
void Draw()
{
		system("cls"); //wyczyszca ekran startowy
		for (int i = 0; i < width + 2; i++) {
			cout << "#";
		}
		cout << endl;

		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				if (j == 0)
					cout << "#";

				if (i == y && j == x)
					cout << "O";

				else if (i == fruitY && j == fruitX)
					cout << "F";

				else {
					bool print = false;
					for (int k = 0; k < nTail; k++) {
						if (tailX[k] == j && tailY[k] == i) {
							cout << "o";
							print = true;
						}
					}
					if (!print)
						cout << " ";
				}

				if (j == width - 1)
					cout << "#";
			}
			cout << endl;
		}
		for (int i = 0; i < width + 2; i++) {
			cout << "#";
		}
		cout << endl;
		cout << "Score: " << score << endl;
}
void Input()
{
		if (_kbhit()) {
			switch (_getch())
			{
			case 'a':
				dir = LEFT;
				break;
			case 'w':
				dir = UP;
				break;
			case 's':
				dir = DOWN;
				break;
			case 'd':
				dir = RIGHT;
				break;
			case 'x':
				gameover = true;
				break;
			}
		}
}
void Logic()
{
		int prevX = tailX[0];
		int prevY = tailY[0];
		int prev2X, prev2Y;
		tailX[0] = x;
		tailY[0] = y;

		for (int i = 1; i < nTail; i++) {
			prev2X = tailX[i];
			prev2Y = tailY[i];
			tailX[i] = prevX;
			tailY[i] = prevY;
			prevX = prev2X;
			prevY = prev2Y;

		}

		switch (dir)
		{
		case LEFT:
			x--;
			break;
		case RIGHT:
			x++;
			break;
		case UP:
			y--;
			break;
		case DOWN:
			y++;
			break;
		}
		if (x > width || x < 0 || y > height || y < 0) {
			gameover = true;
			StartScreen();
		}

		for (int i = 0; i < nTail; i++) {
			if (tailX[i] == x && tailY[i] == y)
				gameover = true;
		}

		if (x == fruitX && y == fruitY) {
			score++;
			nTail++;
			FruitSpawn();
		}
}
int main()
{
		do {
			StartScreen();
			string input;
			cin >> input;
			if (input == "s")
			{
				Setup();
				while (!gameover)
				{
					Draw();
					Input();
					Logic();
					Sleep(100);
				}
			}
			else if (input == "i")
				Instructions();
			else if (input == "q")
				shutDown = true;
		} while (shutDown == false);

		return 0;
}
