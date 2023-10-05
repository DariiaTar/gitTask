#include <iostream>
#include <string>

using namespace std;

int main() {
    int price[] = {25, 50, 47, 80};
    string productName[] ={"bread", "milk", "Chocolate", "Cheese"};
    for(int i = 0; i < 4; i++) {
    cout << "product:" << productName[i] << endl;
    cout << "price:" << price[i] << "uah" << endl;
    }
    return 0;
}