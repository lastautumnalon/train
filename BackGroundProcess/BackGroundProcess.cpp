// BackGroundProcess.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <string>
#include <cstdlib>
using namespace std;
int main()
{
    string map[51] = { "a","i","u","e","o",
                       "ka" ,"ki","ku","ke","ko",
    "sa","si","su","se","so",
    "ta","ci","cu","te","to",
    "na","ni","nu","ne","no",
    "ha","hi","hu","he","ho",
    "ma","mi","mu","me","mo",
    "ya","i","yu","e","yo",
    "ra","ri","ru","re","lo",
    "wa","i","u","e","wo","n" };
    string a[51] = { "あ","い","う","え","お",
                       "か" ,"き","く","け","こ",
    "さ","し","す","せ","そ",
    "た","ち","つ","て","と",
    "な","に","ぬ","ね","の",
    "は","ひ","ふ","へ","ほ",
    "ま","み","む","め","も",
    "や","い","ゆ","え","よ",
    "ら","り","る","れ","ろ",
    "わ","い","う","え","を","ん" };
    string b[51]{
        "ア","イ","ウ","エ","オ",
        "カ" ,"キ","ク","ケ","コ",
        "サ","シ","ス","セ","ソ",
        "タ","チ","ツ","テ","ト",
        "ナ","ニ","ヌ","ネ","ノ",
        "ハ","ヒ","フ","ヘ","ホ",
        "マ","ミ","ム","メ","モ",
        "ヤ","イ","ユ","エ","ヨ",
        "ラ","リ","ル","レ","ロ",
        "ワ","イ","ウ","エ","ヲ","ン"
    };
    int cnt,c;
    string t;
    while (cin >> c) {
        switch (c) {
            case 0://平假名
                srand(time(0));
                cnt = rand() % 51;
                cout << a[cnt] << endl;
    
                while (1) {
                    cin >> t;
                    if (t == map[cnt]) {
                        cout << "Bingo!" << endl;
                        break;
                    }
                    else {
                        cout << "WA" << endl;
                    }
                }
                break;
            case 1://片假名
                srand(time(0));
                cnt = rand() % 51;
                cout << b[cnt] << endl;
                while (1) {
                    cin >> t;
                    if (t == map[cnt]) {
                        cout << "Bingo!" << endl;
                        break;
                    }
                    else {
                        cout << "WA" << endl;
                    }
                }
                break;
            case 2://混合
                srand(time(0));
                cnt = rand() % 2;
                if (cnt == 0) {
                    cnt = rand() % 51;
                    cout << a[cnt] << endl;
                }
                else {
                    cnt = rand() % 51;
                    cout << b[cnt] << endl;
                }
                while (1) {
                    cin >> t;
                    if (t == map[cnt]) {
                        cout << "Bingo!" << endl;
                        break;
                    }
                    else {
                        cout << "WA" << endl;
                    }
                }
                break;
            default:
                cout << "请输入正确内容。"<<endl;
                break;
        }
    }
}