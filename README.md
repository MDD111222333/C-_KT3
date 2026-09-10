# C#_KT3
Вариант 1. Money (деньги)
Класс Money хранит сумму (decimal Amount). Отрицательное значение допустимо и означает долг — отдельных проверок на знак не требуется.

    Конструктор Money(decimal amount) — просто сохраняет сумму.
    public static Money operator +(Money a, Money b) — складывает суммы.
    public static Money operator -(Money a, Money b) — вычитает суммы.
    public static Money operator -(Money a) — унарный минус, возвращает сумму с противоположным знаком.
    Переопределите ToString(), например: "125,50 руб." (для отрицательной суммы — со знаком минус).
