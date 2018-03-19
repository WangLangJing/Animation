#include <iostream>
using namespace std;
int main()
{
	float test = 16777216;
	test++;
	test++;
	test++;

	test += 2;
	test++;
	test++;
	test++;
	//cout << test << endl;
	printf("%.2f\n", test);
	return 0;
}