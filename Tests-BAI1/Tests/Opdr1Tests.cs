// using NUnit.Framework;
// using System.Collections.Generic;
// using System.Linq;
//
// namespace BAI
// {
//     [TestFixture]
//     public class Opdr1Tests
//     {
//         [TestCase("", "")]   // Lege lijst
//         [TestCase("1 3 5 7 3 8 9 5", "3 5 3 5")]   // Voorbeeld
//         [TestCase("42", "")] // Slechts 1 item
//         [TestCase("1 2 3 4 1 2 4 3 6 9 7 8 6 8 7 9", "1 2 3 4 1 2 4 3 6 9 7 8 6 8 7 9")]   // Allemaal repeterend
//         [TestCase("7 7 7 7 7", "7 7 7 7 7")]   // Alleen maar repeterend
//         [TestCase("1 3 7 10 15 89 2 6", "")]   // Niets repeterend
//         [TestCase("165 166 172 12 342 217 441 150 383 379 23 440 179 286 206 395 157 141 358 388 39 419 376 491 55 481 392 337 218 234 232 421 307 243 214 377 158 430 352 430 191 242 152 76 302 6 396 419 56 104 197 59 287 197 471 246 290 181 456 360 324 104 431 150 148 102 133 436 72 329 237 226 289 427 198 296 267 300 189 50 86 472 282 115 37 173 135 111 271 468 88 476 474 491 107 87 310 3 428 201 372 459 348 226 366 471 269 359 498 176 478 489 491 406 275 351 322 317 113 474 466 22 166 104 242 261 251 298 321 112 485 265 371 488 177 126 125 56 248 65 403 276 113 96 489 98 484 69 216 256 264 493 389 454 235 351 294 245 484 106 220 471 38 387 190 213 119 4 229 150 226 267 69 48 71 190 409 71 114 145 276 183 83 66 347 492 376 417 253 326 331 380 71 143 344 432 238 226 405 277 478 481 339 67 30 497 425 341 383 45 441 224 131 339 330 38 388 472 40 198 337 201 250 402 318 346 196 425 203 139 452 184 165 337 166 295 343 17 36 350 68 35 35 209 385 108 249 232 313 307 44 266 186 208 439 277 231 436 248 184 302 499 138 244 93 257 60 294 174 35 194 372 436 190 131 303 167 42 18 211 97 464 113 396 95 186 498 456 397 388 64 406 269 352 48 68 396 290 117 128",
//             "165 166 441 150 383 388 419 376 491 481 337 232 307 430 352 430 242 302 396 419 56 104 197 197 471 290 456 104 150 436 226 198 267 472 474 491 201 372 226 471 269 498 478 489 491 406 351 113 474 166 104 242 56 248 276 113 489 484 69 351 294 484 471 38 190 150 226 267 69 48 71 190 71 276 376 71 226 277 478 481 339 425 383 441 131 339 38 388 472 198 337 201 425 184 165 337 166 68 35 35 232 307 186 277 436 248 184 302 294 35 372 436 190 131 113 396 186 498 456 388 406 269 352 48 68 396 290")]
//         
//         public void Opdr1(string input_str, string expected)
//         {
//             // Arrange
//             List<int> list = TestUtils.IntListFromString(input_str);
//
//             // Act
//             BAI_Afteken1.Opdr1FilterList(list);
//
//             // Assert
//             Assert.AreEqual(expected, TestUtils.EnumToString(list));
//         }
//     }
// }