<?php

/*

○ ＝＝＝　線形探査　＝＝＝

■指定された値の位置 2

入力例1
5-3 2 0 -1 22

出力例1
5

*/

$num = fgets(STDIN);
$arr = explode(" ", fgets(STDIN));
$t = fgets(STDIN);

$ans = 0;
foreach ($arr as $key => $val) {

    if ($val == $t) {
        $ans = $key;
    }
}

print($ans + 1);


/*
○ ＝＝＝　構造体の作成　＝＝＝

https://paiza.jp/works/mondai/class_primer/class_primer__make

入力例1

1 koko 23 04/10 tokyo

出力例1

User{

nickname : koko

old : 23

birth : 04/10

state : tokyo

}
*/

// === ループ回数 & データの要素数　取得
$num = fgets(STDIN);

// ====== $num 回回して 構造体生成
for ($i = 0; $i < $num; $i++) {
    // === explode して、要素を分割
    [$a, $b, $c, $d] = explode(' ', trim(fgets(STDIN)));

    if ($i == $num - 1) {  // === 最後の要素の場合は、 「\n」改行を入れない。
        print("User{" . "\n");
        print("nickname : " . $a . "\n");
        print("old : " . $b . "\n");
        print("birth : " . $c . "\n");
        print("state : " . $d . "\n");
        print("}");
    } else {
        print("User{" . "\n");
        print("nickname : " . $a . "\n");
        print("old : " . $b . "\n");
        print("birth : " . $c . "\n");
        print("state : " . $d . "\n");
        print("}" . "\n");
    } // ======== END IF

} //======================= END FOR


//=================================== Start 
fscanf(STDIN, "%d %d", $N, $M);

fscanf(STDIN, "%d %d %d", $A, $B, $C);

// $N => 店舗数, $M => 営業月数

// $A => 店舗の建設費 , $B => 人件費 , $C => １杯当たりの利益

// $M カ月間に販売した $N ラーメンの肺数

$arr = [];
for ($i = 0; $i < $N; $i++) {
    $arr[$i] = trim(fgets(STDIN));
}

$ans = 0;
// 判定
for ($i = 0; $i < $N; $i++) {
    if (($C * ($arr[$i]) - $A - ($B * $M) . "\n") >= 0) {
    } else {
        $ans = $ans + 1;
    }
}

print($ans);

//=================================== END


/*
 入力例1
 abc def ghi jkl EOF

出力例1

abc
def
ghi
jkl
EOF
*/

$in = fgets(STDIN);
$arr = explode(" ", $in);

// === EOF の文字列があったら　改行なし
foreach ($arr as $val) {
    if (strcmp($val, "EOF") == 0) {
        print($val);
    } else {
        print($val . "\n");
    }
}

/*
入力例1
1 2 3 4 5 -1

出力例1
1
2
3
4
5
-1

*/
$input_line = fgets(STDIN);
$arr = explode(" ", $input_line);

// === 出力
foreach ($arr as $val) {
    if ($val != -1) {
        print($val . "\n");
    } else {
        print($val);
    }
}


/*
配列の入力 1
https://paiza.jp/works/mondai/array_primer/array_primer__1dmatrix_input_step1
*/

$arr = [8, 1, 3, 3, 8, 1, 1, 3, 8, 8];

function arr_print(array $arr)
{
    $len = count($arr);
    //print($len);
    foreach ($arr as $key => $val) {

        if ($key != $len - 1) {
            print($val . "\n");
        } else {
            print($val);
        }
    }
}

arr_print($arr);

/*
============= 「i 番目の出力 PHP編」 ==============
*/
$arr = [5, 1, 3, 4, 5, 12, 6, 8, 1, 3];

function arr_out(String $num, array $arr)
{
    print $arr[$num - 1];
}

arr_out(4, $arr);
