def calc(n):
    n = int(n)
    if n == 1 or n == 2:
        return 1
    else:
        i = 2
        p2 = 1
        p1 = 1
        res = 0
        while i < n:
            res = p1 + p2
            p2 = p1
            p1 = res
            i += 1
        return res


n = input("Input n:")
print("第" + n + "个斐波那契元素为：" + str(calc(n)))
