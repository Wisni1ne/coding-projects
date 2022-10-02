/**
 Name        : smash.c
 Author      : Nathan Wisniewski
 Version     : 2.19.03.04
 Description : Custom program to run on a RGB LED Matrix.
 	 	 	   This program counts down from a set time (Minute:Seconds:MiliSec) and displays on the matrix.
 */

#include "led-matrix-c.h"

#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <time.h>
#include <math.h>

int main(int argc, char **argv) {

	struct RGBLedMatrixOptions options;
	struct RGBLedMatrix *matrix;
	struct LedCanvas *offscreen_canvas;

	// assign LedFonts

	struct LedFont *font1;
	struct LedFont *font2;
	struct LedFont *font3;
	struct LedFont *font4;
	struct LedFont *font5;

	int width, height;
	int x, y, i;

	memset(&options, 0, sizeof(options));
	options.rows = 16;
	options.chain_length = 1;
	matrix = led_matrix_create_from_options(&options, &argc, &argv);

	if (matrix == NULL)
		return 1;

	offscreen_canvas = led_matrix_create_offscreen_canvas(matrix);

	led_canvas_get_size(offscreen_canvas, &width, &height);

	fprintf(stderr, "Size: %dx%d. Hardware gpio mapping: %s\n",
			width, height, options.hardware_mapping);

	// load in fonts
	font1 = load_font("8x13.bdf");
	font2 = load_font("6x10.bdf");
	font3 = load_font("5x8.bdf");
	font4 = load_font("5x7.bdf");
	font5 = load_font("8x13B.bdf");

	// "this is where the fun begins"
	int xsec = 0; // seconds
	int xmil = 0; // miliseconds
	int countt = 0; // set number, in seconds
	int remaint = 0; // remaining time, in seconds
	int printmil = 0; // for printing miliseconds to matrix

	int print2mil = 0;

	int countmin = 0; // temp values to assist display
	int countsec = 0;

	int tempwidth; // temp width for decreasing background
	float percent; // percent of time remaining

	clock_t xstart, xcount; // clock to count time

	countt = 180;  // THIS IS WHERE TO SET THE TIME, IN SECONDS

	countt = countt - 1; // remove first second for display reasons

	xstart = clock(); // start the timer
	remaint = countt - xsec; // xsec is increasing, subtract set seconds (countt) by xsec

	while (remaint >= 0) { // 0 should be the last second to count down

		xcount = clock(); // count timer
		xmil = xcount - xstart; // get miliseconds
		xsec = (xmil / (CLOCKS_PER_SEC)); // get seconds

		remaint = countt - xsec; // count down

		countmin = remaint / 60; // minutes remaining, for display
		countsec = remaint % 60; // seconds remaining, for display

		while (xmil > 1000000) { // helps with displaying miliseconds by a single digit (takes left-most digit)
			xmil = xmil - 1000000;
		}

		printmil = xmil / 100000; // helps display single digit miliseconds
		printmil = 9 - printmil;

		print2mil = xmil / 10000;
		print2mil = 99 - printmil;

		printf("Time: %d:%d.%d \n", countmin, countsec, print2mil); // Prints time remaining in terminal

		percent = (float)remaint / countt; // percentage of time remaining, used for background

		tempwidth =  (width * percent); // sets background width

		// Display the background, decreases in width when time decreases

		for (i = 0; i < 1; ++i) {
			for (y = 0; y < height; ++y) {
				for (x = 0; x < tempwidth; ++x) {
					led_canvas_set_pixel(offscreen_canvas, x, y, 55, 0, 0);
				}
			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

		}

		//========================================================================================================================================================================//

		if (countmin >= 10) {

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			//draw_text(offscreen_canvas, font4, 23, 12, 255, 255, 0, ".", 0); // milisecond separator

			draw_text(offscreen_canvas, font3, 14, 10, 255, 255, 0, ":", 0); // second separator

			// Display first digit of second

			if ((countsec % 10) == 9) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "9", 0);

			}

			else if ((countsec % 10) == 8) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "8", 0);

			}

			else if ((countsec % 10) == 7) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "7", 0);

			}

			else if ((countsec % 10) == 6) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "6", 0);

			}

			else if ((countsec % 10) == 5) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "5", 0);

			}

			else if ((countsec % 10) == 4) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "4", 0);

			}

			else if ((countsec % 10) == 3) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "3", 0);

			}

			else if ((countsec % 10) == 2) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "2", 0);

			}

			else if ((countsec % 10) == 1) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "1", 0);

			}

			else if ((countsec % 10) == 0) {

				draw_text(offscreen_canvas, font1, 24, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display second digit of second

			if ((countsec / 10) == 9) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "9", 0);

			}

			else if ((countsec / 10) == 8) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "8", 0);

			}

			else if ((countsec / 10) == 7) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "7", 0);

			}

			else if ((countsec / 10) == 6) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "6", 0);

			}

			else if ((countsec / 10) == 5) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "5", 0);

			}

			else if ((countsec / 10) == 4) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "4", 0);

			}

			else if ((countsec / 10) == 3) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "3", 0);

			}

			else if ((countsec / 10) == 2) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "2", 0);

			}

			else if ((countsec / 10) == 1) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "1", 0);

			}

			else if ((countsec / 10) == 0) {

				draw_text(offscreen_canvas, font1, 17, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display minute

			if ((countmin % 10) == 9) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "9", 0);

			}

			else if ((countmin % 10) == 8) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "8", 0);

			}

			else if ((countmin % 10) == 7) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "7", 0);

			}

			else if ((countmin % 10) == 6) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "6", 0);

			}

			else if ((countmin % 10) == 5) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "5", 0);

			}

			else if ((countmin % 10) == 4) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "4", 0);

			}

			else if ((countmin % 10) == 3) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "3", 0);

			}

			else if ((countmin % 10) == 2) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "2", 0);

			}

			else if ((countmin % 10) == 1) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "1", 0);

			}

			else if ((countmin % 10) == 0) {

				draw_text(offscreen_canvas, font1, 7, 12, 255, 255, 0, "0", 0);

			}

			// left digit below

			if ((countmin / 10) == 9) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "9", 0);

			}

			else if ((countmin / 10) == 8) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "8", 0);

			}

			else if ((countmin / 10) == 7) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "7", 0);

			}

			else if ((countmin / 10) == 6) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "6", 0);

			}

			else if ((countmin / 10) == 5) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "5", 0);

			}

			else if ((countmin / 10) == 4) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "4", 0);

			}

			else if ((countmin / 10) == 3) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "3", 0);

			}

			else if ((countmin / 10) == 2) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "2", 0);

			}

			else if ((countmin / 10) == 1) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "1", 0);

			}

			else if ((countmin / 10) == 0) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

		}

		//========================================================================================================================================================================//

		else if (countmin > 0 && countmin < 10) {

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			draw_text(offscreen_canvas, font4, 23, 12, 255, 255, 0, ".", 0); // milisecond separator

			draw_text(offscreen_canvas, font3, 6, 10, 255, 255, 0, ":", 0); // second separator

			// Display milisecond

			if (printmil == 9) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "9", 0);

			}

			else if (printmil == 8) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "8", 0);

			}

			else if (printmil == 7) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "7", 0);

			}

			else if (printmil == 6) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "6", 0);

			}

			else if (printmil == 5) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "5", 0);

			}

			else if (printmil == 4) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "4", 0);

			}

			else if (printmil == 3) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "3", 0);

			}

			else if (printmil == 2) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "2", 0);

			}

			else if (printmil == 1) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "1", 0);

			}

			else if (printmil == 0) {

				draw_text(offscreen_canvas, font2, 27, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display first digit of second

			if ((countsec % 10) == 9) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "9", 0);

			}

			else if ((countsec % 10) == 8) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "8", 0);

			}

			else if ((countsec % 10) == 7) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "7", 0);

			}

			else if ((countsec % 10) == 6) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "6", 0);

			}

			else if ((countsec % 10) == 5) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "5", 0);

			}

			else if ((countsec % 10) == 4) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "4", 0);

			}

			else if ((countsec % 10) == 3) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "3", 0);

			}

			else if ((countsec % 10) == 2) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "2", 0);

			}

			else if ((countsec % 10) == 1) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "1", 0);

			}

			else if ((countsec % 10) == 0) {

				draw_text(offscreen_canvas, font1, 16, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display second digit of second

			if ((countsec / 10) == 9) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "9", 0);

			}

			else if ((countsec / 10) == 8) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "8", 0);

			}

			else if ((countsec / 10) == 7) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "7", 0);

			}

			else if ((countsec / 10) == 6) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "6", 0);

			}

			else if ((countsec / 10) == 5) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "5", 0);

			}

			else if ((countsec / 10) == 4) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "4", 0);

			}

			else if ((countsec / 10) == 3) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "3", 0);

			}

			else if ((countsec / 10) == 2) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "2", 0);

			}

			else if ((countsec / 10) == 1) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "1", 0);

			}

			else if ((countsec / 10) == 0) {

				draw_text(offscreen_canvas, font1, 9, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display minute

			if (countmin == 9) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "9", 0);

			}

			else if (countmin == 8) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "8", 0);

			}

			else if (countmin == 7) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "7", 0);

			}

			else if (countmin == 6) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "6", 0);

			}

			else if (countmin == 5) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "5", 0);

			}

			else if (countmin == 4) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "4", 0);

			}

			else if (countmin == 3) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "3", 0);

			}

			else if (countmin == 2) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "2", 0);

			}

			else if (countmin == 1) {

				draw_text(offscreen_canvas, font1, 0, 12, 255, 255, 0, "1", 0);

			}

			else if (countmin == 0) {

				draw_text(offscreen_canvas, font1, -1, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

		}

		//========================================================================================================================================================================//

		else if (countmin == 0) {

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			draw_text(offscreen_canvas, font4, 15, 12, 255, 255, 0, ".", 0); // milisecond separator

			//draw_text(offscreen_canvas, font3, 6, 10, 255, 255, 0, ":", 0); // second separator

			// Display milisecond

			if ((print2mil % 10) == 9) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "9", 0);

			}

			else if ((print2mil % 10) == 8) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "8", 0);

			}

			else if ((print2mil % 10) == 7) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "7", 0);

			}

			else if ((print2mil % 10) == 6) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "6", 0);

			}

			else if ((print2mil % 10) == 5) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "5", 0);

			}

			else if ((print2mil % 10) == 4) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "4", 0);

			}

			else if ((print2mil % 10) == 3) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "3", 0);

			}

			else if ((print2mil % 10) == 2) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "2", 0);

			}

			else if ((print2mil % 10) == 1) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "1", 0);

			}

			else if ((print2mil % 10) == 0) {

				draw_text(offscreen_canvas, font2, 26, 12, 255, 255, 0, "0", 0);

			}

			// left below

			if ((print2mil / 10) == 9) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "9", 0);

			}

			else if ((print2mil / 10) == 8) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "8", 0);

			}

			else if ((print2mil / 10) == 7) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "7", 0);

			}

			else if ((print2mil / 10) == 6) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "6", 0);

			}

			else if ((print2mil / 10) == 5) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "5", 0);

			}

			else if ((print2mil / 10) == 4) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "4", 0);

			}

			else if ((print2mil / 10) == 3) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "3", 0);

			}

			else if ((print2mil / 10) == 2) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "2", 0);

			}

			else if ((print2mil / 10) == 1) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "1", 0);

			}

			else if ((print2mil / 10) == 0) {

				draw_text(offscreen_canvas, font2, 19, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display first digit of second

			if ((countsec % 10) == 9) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "9", 0);

			}

			else if ((countsec % 10) == 8) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "8", 0);

			}

			else if ((countsec % 10) == 7) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "7", 0);

			}

			else if ((countsec % 10) == 6) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "6", 0);

			}

			else if ((countsec % 10) == 5) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "5", 0);

			}

			else if ((countsec % 10) == 4) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "4", 0);

			}

			else if ((countsec % 10) == 3) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "3", 0);

			}

			else if ((countsec % 10) == 2) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "2", 0);

			}

			else if ((countsec % 10) == 1) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "1", 0);

			}

			else if ((countsec % 10) == 0) {

				draw_text(offscreen_canvas, font1, 8, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

			// Display second digit of second

			if ((countsec / 10) == 9) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "9", 0);

			}

			else if ((countsec / 10) == 8) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "8", 0);

			}

			else if ((countsec / 10) == 7) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "7", 0);

			}

			else if ((countsec / 10) == 6) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "6", 0);

			}

			else if ((countsec / 10) == 5) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "5", 0);

			}

			else if ((countsec / 10) == 4) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "4", 0);

			}

			else if ((countsec / 10) == 3) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "3", 0);

			}

			else if ((countsec / 10) == 2) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "2", 0);

			}

			else if ((countsec / 10) == 1) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "1", 0);

			}

			else if ((countsec / 10) == 0) {

				draw_text(offscreen_canvas, font1, 1, 12, 255, 255, 0, "0", 0);

			}

			offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);

			led_canvas_clear(offscreen_canvas); // resets canvas so drawing does not stack up

		}

	}

	//========================================================================================================================================================================//

	// When time is expired

	for (i = 0; i < 100; ++i) {
		for (y = 0; y < height; ++y) {
			for (x = 0; x < width; ++x) {
				if ((i / 8) % 2 == 0) { // Blink color set 1
					led_canvas_set_pixel(offscreen_canvas, x, y, 105, 0, 0);
					draw_text(offscreen_canvas, font5, 1, 12, 0, 0, 0, "T", 0);
					draw_text(offscreen_canvas, font5, 7, 12, 0, 0, 0, "I", 0);
					draw_text(offscreen_canvas, font5, 14, 12, 0, 0, 0, "M", 0);
					draw_text(offscreen_canvas, font5, 22, 12, 0, 0, 0, "E", 0);
				}
				else { // Blink color set 2
					led_canvas_set_pixel(offscreen_canvas, x, y, 0, 0, 0);
					draw_text(offscreen_canvas, font5, 1, 12, 105, 105, 0, "T", 0);
					draw_text(offscreen_canvas, font5, 7, 12, 105, 105, 0, "I", 0);
					draw_text(offscreen_canvas, font5, 14, 12, 105, 105, 0, "M", 0);
					draw_text(offscreen_canvas, font5, 22, 12, 105, 105, 0, "E", 0);
				}
			}
		}
		offscreen_canvas = led_matrix_swap_on_vsync(matrix, offscreen_canvas);
	}

	printf("END \n \n"); // prints end in terminal

	led_matrix_delete(matrix); // Resets display before end of code.

	return 0;
}
