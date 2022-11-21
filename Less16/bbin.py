from random import randint

x = randint(10, 100)
count_perebor = 0
# метод последовательного перебора

for i in range(0, 100):
    count_perebor += 1
    if i == x:
        print("Число найдено!")
        break
print("Загадоное число было", x, " и для его пойска потребовалось ",
      count_perebor, " итерации методом 1")

count_random = 1
# метод случайного отгадывания
y = randint(0, 100)

while x != y:
    y = randint(0, 100)
    count_random += 1
print("Загадоное число было", x,
      " и для его пойска потребовалось угадования  ", count_random,
      " итерации")
