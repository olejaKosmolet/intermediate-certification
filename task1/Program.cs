﻿// uint A(uint m, uint n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//       if ((m != 0) && (n == 0))
//         return A(m - 1, 1);
//     else
//         return A(m - 1, A(m, n - 1));
// }


//          {n+1, если m = 0;
// A(m,n) = {A(m - 1, 1), если m != 0, m = 0;
//          {A(m - 1, A(m,n - 1)), если m > 0, m > 0. 