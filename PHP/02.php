<?php

/*

入力例1
5-3 2 0 -1 22

出力例1
2

*/

$num = fgets(STDIN);
$arr = explode(" ", fgets(STDIN));
$t = fgets(STDIN);

$ans = 0;
foreach ($arr as $key => $val) {

    if ($val == $t) {
        $ans = $key + 1;
        break;
    } else {
        $ans = "0";
    }
}

print($ans);

/*

入力例1

5-3 2 0 -1 22

出力例1


*/


$n = fgets(STDIN);
$arr = explode(" ", fgets(STDIN));
$t = fgets(STDIN);

$ans = 0;

foreach ($arr as $a) {
    if ($a == $t) {
        $ans += 1;
    }
}

print($ans);

/*
期待する出力
```
min
max
```

入力例1

```
3
7 5 12
10 6 20
12 3 8

```
出力例1

```
20
31

```
入力例2

```
2
1 1 23
23 1 1

```
出力例2

```
3
47

```
入力例3

```
1
5 4 20

```
出力例3

```
13
13
```
*/

$num = fgets(STDIN);

for ($i = 0; $i < $num; $i++) {
    $arr[] = explode(" ", fgets(STDIN));
}

$arr_sum = [];
for ($i = 0; $i < $num; $i++) {
    for ($j = 0; $j < count($arr[$i]); $j++) {
        if ($j == 2) {
            $arr_sum[$i] += 24 - $arr[$i][$j];
        } else {
            $arr_sum[$i] += $arr[$i][$j];
        }
    }
}

$r_min = min($arr_sum);
$r_max = max($arr_sum);

print($r_min . "\n");
print($r_max);


/*

「二重ループメニュー」
■ === 行列の転置 ===

入力例1

2 3
1 2 3
4 5 6

出力例1

1 4
2 5
3 6

*/

fscanf(STDIN, "%d %d", $h, $w);

for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(" ", trim(fgets(STDIN)));
}

// === 行列の入れ替え ===
$arr_t = [];
for ($i = 0; $i < $h; $i++) {
    for ($j = 0; $j < $w; $j++) {
        $arr_t[$j][$i] = $arr[$i][$j];
    }
}

//=== 転置行列の表示 ===
for ($j = 0; $j < $w; $j++) {
    for ($i = 0; $i < $h; $i++) {

        // === 出力が最後の列の値なら、改行する。
        if ($i == $h - 1) {
            print($arr_t[$j][$i]);
            print("\n");
        } else {
            // === 最後の列以外の値だったら、空白を入れる。
            print($arr_t[$j][$i] . " ");
        }
    }
}

/*
■ === 二重ループ：基本編　積の最大 ===

入力例1

10 10
85 -46 93 44 -40 -75 -75 -18 -54 95
1 95 -92 -90 32 -25 36 55 22 86

出力例1

9025

入力例2

1 1
-59
-16

出力例2

944

*/
fscanf(STDIN, "%d %d", $h, $w);

for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(" ", fgets(STDIN));
}

$result = [];
for ($i = 0; $i < $h; $i++) {
    for ($j = 0; $j <= $w; $j++) {

        // === 大きい値を右のindex へ移動
        if ($arr[$i][$j] > $arr[$i][$j + 1]) {
            $tmp = $arr[$i][$j];
            $arr[$i][$j] = $arr[$i][$j + 1];
            $arr[$i][$j + 1] = $tmp;

            $result[$i] = $arr[$i][$j + 1];
        } else if ($arr[$i][$j] < $arr[$i][$j + 1]) {
            $result[$i] = $arr[$i][$j + 1];

            // === $w 比較する値が 1個しかない場合
        } else if ($w <= 0) {
            $result[$i] = $arr[$i][$j];
            break;

            // === 横軸のループを最後まで回したら、ループを抜ける。
        } else if ($j == $w) {
            break;
        }
    }
}

// === 最大値　の値同士で掛け算をする。
$a = 1;
foreach ($result as $r) {
    $a *= $r;
}

print($a);

/*

入力例2
5

出力例2
1

1 2

1 2 3

1 2 3 4

1 2 3 4 5

*/
$h = fgets(STDIN);

$arr_sum = [];
for ($i = 1; $i <= $h; $i++) {
    for ($j = 1; $j <= $i; $j++) {

        // ========　横軸の最後尾の値になったら 改行
        if ($j == $i) {
            print($j . "\n");
        } else {
            print($j . " ");
        }
    }
}

/*
入力例2

10
12 17 11 44 41 18 12 70 82 72 19 20 97
8 22 36 93 80 28 59 96 57
10 90 27 95 66 57 48 86 43 81 31
13 22 2 52 51 41 28 83 71 52 10 78 9 19
14 11 96 37 0 50 65 3 4 81 64 47 32 46 53
5 73 22 40 29 69
1 35
3 32 4 41
1 73
1 46

出力例2

503

471

624

518

589

233

35

77

73

46
*/
fscanf(STDIN, "%d", $h);

for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(' ', fgets(STDIN));
}

$arr_sum = [];
for ($i = 0; $i < $h; $i++) {
    // === count($arr[$i]) で、横の配列の長さを取得
    for ($j = 1; $j < count($arr[$i]); $j++) {
        $arr_sum[$i] += $arr[$i][$j];
    }
}

foreach ($arr_sum as $a) {
    print($a . "\n");
}

/*

入力例1
3 3
1 2 3
4 5 6
7 8 9

出力例1
6

15

24

*/
fscanf(STDIN, "%d %d", $h, $w);

// === ２次元配列作成   
for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(" ", fgets(STDIN));
}

// === ２次元配列の　行　の　和を求める
$arr_sum = [];
for ($i = 0; $i < $h; $i++) {
    for ($j = 0; $j < $w; $j++) {
        $arr_sum[$i] += $arr[$i][$j];
    }
}

// === 出力
foreach ($arr_sum as $a) {
    print($a . "\n");
}

/*

入力例1
3 3
226 409 419
491 524 82
417 954 751

出力例1
954

*/
fscanf(STDIN, "%d %d", $h, $w);

for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(' ', trim(fgets(STDIN)));
}

$ans = $arr[0][0];

// === 最大値を入れる　全探索  配列の１番目の要素と比較して、それより大きい場合は ===
// 大きい要素を $ans に入れる。
for ($i = 0; $i < $h; $i++) {
    for ($j = 0; $j < $w; $j++) {
        if ($ans < $arr[$i][$j]) {
            $ans = $arr[$i][$j];
        }
    }
}
print($ans);

/*
■二次元配列での要素の検索

入力例1
4 3
0 0 0
0 0 0
0 0 1
0 0 0

出力例1
3 3

*/
fscanf(STDIN, "%d %d", $h, $w);

// === ２次元配列取得
for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(' ', trim(fgets(STDIN)));
}

$i_num = 0;
$j_num = 0;

// ===２次元配列　出力
for ($i = 0; $i < $h; $i++) {
    for ($j = 0; $j < $w; $j++) {
        if ($arr[$i][$j] == 1) {
            $i_num = $i;
            $j_num = $j;
        }
    }
}

// === 1のある index  縦、　横　出力
print($i_num + 1 . " " . $j_num + 1);

/*
入力例1
3 4
92 15 49 19
20 89 92 47
0 87 42 45

出力例1
92 15 49 19

20 89 92 47

0 87 42 45
*/
fscanf(STDIN, "%d %d", $h, $w);

// === ２次元配列作成
for ($i = 0; $i < $h; $i++) {
    $arr[] = explode(' ', trim(fgets(STDIN)));
}

// === ２次元配列　出力
for ($i = 0; $i < $h; $i++) {
    for ($j = 0; $j < $w; $j++) {
        if ($j == $w - 1) {
            print($arr[$i][$j] . "\n");
        } else {
            print($arr[$i][$j] . " ");
        }
    }
}

print_r($arr);

/*

```
N K
```
・ 1 行で整数 N , K が半角スペース区切りで与えられます。

入力例1
5 5

出力例1
1 2 3 4 5

1 2 3 4 5

1 2 3 4 5

1 2 3 4 5

1 2 3 4 5

*/
fscanf(STDIN, "%d %d", $a, $b);

for ($i = 1; $i <= $b; $i++) {

    for ($j = 1; $j <= $a; $j++) {

        if ($j == $a) {
            print($j . "\n");
        } else {
            print($j . " ");
        }
    }
}

/*

入力例1
5

出力例1
1 2 3 4 5

1 2 3 4 5

1 2 3 4 5

1 2 3 4 5

1 2 3 4 5
*/
$num = fgets(STDIN);

for ($i = 0; $i < $num; $i++) {
    for ($j = 1; $j <= 5; $j++) {

        if ($j == 5) {
            print($j . "\n");
        } else {
            print($j . " ");
        }
    }
}

// =============================== start
$num = fgets(STDIN);

$arr = [];
$arr_02 = [];
$idx = 0;
for ($i = 0; $i < $num; $i++) {
    fscanf(STDIN, "%d %d", $a, $b);
    $arr[$i] = $a;
    $arr_02[$i] = $b;
}

$j = 0;
$result = 0;
while ($num > $j) {
    if ($arr[$j] == $arr_02[$j]) {
        $result += $arr[$j] * $arr_02[$j];
    } else {
        $result += $arr[$j] + $arr_02[$j];
    }

    $j++;
}
print($result);
// =============================== end

// =============================== start
$arr = [4, 0, 5, -1, 3, 10, 6, -8];

$arr_result = [];

$i = 0;
foreach ($arr as $a) {
    if ($a >= 5) {
        $arr_result[$i] = $a;
    }
    $i++;
}

// array_sum => 配列の合計値
print(array_sum($arr_result));

// =============================== end