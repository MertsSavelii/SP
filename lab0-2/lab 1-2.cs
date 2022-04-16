// pattern_5 = @"192\.168\.0\.\d{1,3}"
//Соответствует любому IP-адресу в диапазоне
// G = (T, V, P, S0);
// T = {192.168.0., 0-9};
// P = {p1, p2};
// V = {S0, A, B, C, D}.

// p1: S0 -> 192.168.0.A,
// p2: A -> 0B | 1B | 2B | 3B | 4B | 5B | 6B | 7B | 8B | 9B,
// p2: B -> 0C | 1C | 2C | 3C | 4C | 5C | 6C | 7C | 8C | 9C,
// p2: C -> 0D | 1D | 2D | 3D | 4D | 5D | 6D | 7D | 8D | 9D,
// p2: D -> ε


// Цепочка: S0 => 192.168.0.A => 192.168.0.asfasdf
// Цепочка: S0 => 192.168.0.A => 192.168.0.123


// Конечный автомат
// L(KA) == L(G)
// KA = (Q, sigma, delta, q0, F)
// KA = T = ({S0, A, B, C, D, qf}, {192.168.0., 0-9}, delta, S0, {qf})

// Функция перехода(delta):
// delta(S0, 192.168.0.) = {A};
// delta(A, 0-9) = {B};
// delta(B, 0-9) = {C};
// delta(C, 0-9) = {D};
// delta(D, ε) = {qf}.

// Конфигурация КА:
// (S0, 192.168.0.123) |- (A, 123) |- (B, 23) |- (C, 23) |- (D, ε) |- (qf, ε)
// Недетермированный КА


//pattern_6 = @"(\W|^)po[#\-]{0,1}\s{0,1}\d{2}[\s-]{0,1}\d{4}(\W|$)"; 
// Сопоставьте номера заказов на покупку
//G = (T, V, P, S0);
//T = {po, 0-9, -, #, " "};
//P = {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10};
//V = {S0, A, B, C, D, E, F, G, H, I}.

//p1: S0 -> poA,
//P2: A -> #B | -B  | " "B, B,
//p3: B -> 0C | 1C | 2C | 3C | 4C | 5C | 6C | 7C | 8C | 9C,
//p4: C -> 0D | 1D | 2D | 3D | 4D | 5D | 6D | 7D | 8D | 9D,
//p5: D -> -E | " "E | E,
//p6: E -> 0F | 1F | 2F | 3F | 4F | 5F | 6F | 7F | 8F | 9F,
//p7: F -> 0G | 1G | 2G | 3G | 4G | 5G | 6G | 7G | 8G | 9G,
//p8: G -> 0H | 1H | 2H | 3H | 4H | 5H | 6H | 7H | 8H | 9H,
//p9: H -> 0I | 1I | 2I | 3I | 4I | 5I | 6I | 7I | 8I | 9I,
//p10: I -> ε

//Цепочка: S0 => poA => po#B => po#2C => po#21D => po#21 E => po#21 0F => po#21 05G => po#21 051H =>po#21 0513I => po#21 0513
//Цепочка: S0 => poA => poB => po0C => po01D => po01-E => po01-4F => po01-42G => po01-420H => po01-4205I => po01-4205


//Конечный автомат
//L(KA) == L(G)
//KA = (Q, sigma, delta, q0, F)
//KA = T = ({S0, A, B, C, D, E, F, G, H, I, qf}, {po, 0-9, -, #, " "}, delta, S0, {qf})

// Функция перехода(delta):
//delta(S0, po) = {A};
//delta(A, #) = {B}; delta(A, -) = {B}; delta(A, " ") = {B};
//delta(B, 0-9) = {C};
//delta(C, 0-9) = {D};
//delta(D, -) = {E}; delta(D," ") = {E};
//delta(E, 0-9) = {F};
//delta(F, 0-9) = {G};
//delta(G, 0-9) = {H};
//delta(H, 0-9) = {I};
//delta(I, ε) = {qf}.

//Конфигурация КА:
//(S0, po#21 0513) |- (A, #21 0513) |- (B, 21 0513) |- (C, 1 0513) |- (D, " "0513), |- (E, 0513) |- (F, 513) |- (G, 13) |- (H, 1) |- (I, ε) |- (qf, ε)
//Недетермированный КА