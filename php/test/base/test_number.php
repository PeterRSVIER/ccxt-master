<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
use \ccxt\Precise;

function test_number() {
    $exchange = new \ccxt\Exchange(array(
        'id' => 'regirock',
    ));
    // ----------------------------------------------------------------------------
    // numberToString
    assert($exchange->number_to_string(-7.8e-7) === '-0.00000078');
    assert($exchange->number_to_string(7.8e-7) === '0.00000078');
    assert($exchange->number_to_string(-0.0000017805) === '-0.0000017805');
    assert($exchange->number_to_string(0.0000017805) === '0.0000017805');
    assert($exchange->number_to_string(-7.0005e+27) === '-7000500000000000000000000000');
    assert($exchange->number_to_string(7.0005e+27) === '7000500000000000000000000000');
    assert($exchange->number_to_string(-7.9e+27) === '-7900000000000000000000000000');
    assert($exchange->number_to_string(7e+27) === '7000000000000000000000000000');
    assert($exchange->number_to_string(7.9e+27) === '7900000000000000000000000000');
    assert($exchange->number_to_string(-12.345) === '-12.345');
    assert($exchange->number_to_string(12.345) === '12.345');
    assert($exchange->number_to_string(0) === '0');
    assert($exchange->number_to_string(7.35946e+21) === '7359460000000000000000');
    assert($exchange->number_to_string(1e-8) === '0.00000001');
    assert($exchange->number_to_string(1e-7) === '0.0000001');
    assert($exchange->number_to_string(-1e-7) === '-0.0000001');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionTruncationToNDigitsAfterDot
    assert($exchange->decimal_to_precision('12.3456000', TRUNCATE, 100, DECIMAL_PLACES) === '12.3456');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, 100, DECIMAL_PLACES) === '12.3456');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, 4, DECIMAL_PLACES) === '12.3456');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, 3, DECIMAL_PLACES) === '12.345');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, 2, DECIMAL_PLACES) === '12.34');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, 1, DECIMAL_PLACES) === '12.3');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, 0, DECIMAL_PLACES) === '12');
    // ['12.3456',    TRUNCATE,  -1, DECIMAL_PLACES,  '10'],   // not yet supported
    // ['123.456',    TRUNCATE,  -2, DECIMAL_PLACES,  '120'],  // not yet supported
    // ['123.456',    TRUNCATE,  -3, DECIMAL_PLACES,  '100'],  // not yet supported
    assert($exchange->decimal_to_precision('0.0000001', TRUNCATE, 8, DECIMAL_PLACES) === '0.0000001');
    assert($exchange->decimal_to_precision('0.00000001', TRUNCATE, 8, DECIMAL_PLACES) === '0.00000001');
    assert($exchange->decimal_to_precision('0.000000000', TRUNCATE, 9, DECIMAL_PLACES, PAD_WITH_ZERO) === '0.000000000');
    assert($exchange->decimal_to_precision('0.000000001', TRUNCATE, 9, DECIMAL_PLACES, PAD_WITH_ZERO) === '0.000000001');
    assert($exchange->decimal_to_precision('12.3456', TRUNCATE, -1, DECIMAL_PLACES) === '10');
    assert($exchange->decimal_to_precision('123.456', TRUNCATE, -1, DECIMAL_PLACES) === '120');
    assert($exchange->decimal_to_precision('123.456', TRUNCATE, -2, DECIMAL_PLACES) === '100');
    assert($exchange->decimal_to_precision('9.99999', TRUNCATE, -1, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('99.9999', TRUNCATE, -1, DECIMAL_PLACES) === '90');
    assert($exchange->decimal_to_precision('99.9999', TRUNCATE, -2, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('0', TRUNCATE, 0, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('-0.9', TRUNCATE, 0, DECIMAL_PLACES) === '0');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionTruncationToNSignificantDigits
    assert($exchange->decimal_to_precision('0.000123456700', TRUNCATE, 100, SIGNIFICANT_DIGITS) === '0.0001234567');
    assert($exchange->decimal_to_precision('0.0001234567', TRUNCATE, 100, SIGNIFICANT_DIGITS) === '0.0001234567');
    assert($exchange->decimal_to_precision('0.0001234567', TRUNCATE, 7, SIGNIFICANT_DIGITS) === '0.0001234567');
    assert($exchange->decimal_to_precision('0.000123456', TRUNCATE, 6, SIGNIFICANT_DIGITS) === '0.000123456');
    assert($exchange->decimal_to_precision('0.000123456', TRUNCATE, 5, SIGNIFICANT_DIGITS) === '0.00012345');
    assert($exchange->decimal_to_precision('0.000123456', TRUNCATE, 2, SIGNIFICANT_DIGITS) === '0.00012');
    assert($exchange->decimal_to_precision('0.000123456', TRUNCATE, 1, SIGNIFICANT_DIGITS) === '0.0001');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 10, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '123.0000987');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 8, SIGNIFICANT_DIGITS) === '123.00009');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 7, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '123.0000');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 6, SIGNIFICANT_DIGITS) === '123');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 5, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '123.00');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 4, SIGNIFICANT_DIGITS) === '123');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 4, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '123.0');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 3, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '123');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 2, SIGNIFICANT_DIGITS) === '120');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 1, SIGNIFICANT_DIGITS) === '100');
    assert($exchange->decimal_to_precision('123.0000987654', TRUNCATE, 1, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '100');
    assert($exchange->decimal_to_precision('1234', TRUNCATE, 5, SIGNIFICANT_DIGITS) === '1234');
    assert($exchange->decimal_to_precision('1234', TRUNCATE, 5, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '1234.0');
    assert($exchange->decimal_to_precision('1234', TRUNCATE, 4, SIGNIFICANT_DIGITS) === '1234');
    assert($exchange->decimal_to_precision('1234', TRUNCATE, 4, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '1234');
    assert($exchange->decimal_to_precision('1234.69', TRUNCATE, 0, SIGNIFICANT_DIGITS) === '0');
    assert($exchange->decimal_to_precision('1234.69', TRUNCATE, 0, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '0');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionRoundingToNDigitsAfterDot
    assert($exchange->decimal_to_precision('12.3456000', ROUND, 100, DECIMAL_PLACES) === '12.3456');
    assert($exchange->decimal_to_precision('12.3456', ROUND, 100, DECIMAL_PLACES) === '12.3456');
    assert($exchange->decimal_to_precision('12.3456', ROUND, 4, DECIMAL_PLACES) === '12.3456');
    assert($exchange->decimal_to_precision('12.3456', ROUND, 3, DECIMAL_PLACES) === '12.346');
    assert($exchange->decimal_to_precision('12.3456', ROUND, 2, DECIMAL_PLACES) === '12.35');
    assert($exchange->decimal_to_precision('12.3456', ROUND, 1, DECIMAL_PLACES) === '12.3');
    assert($exchange->decimal_to_precision('12.3456', ROUND, 0, DECIMAL_PLACES) === '12');
    // todo:
    // ['9.999',     ROUND,   3, DECIMAL_PLACES,    NO_PADDING,  '9.999'],
    // ['9.999',     ROUND,   2, DECIMAL_PLACES,    NO_PADDING,  '10'],
    // ['9.999',     ROUND,   2, DECIMAL_PLACES, PAD_WITH_ZERO,  '10.00'],
    // ['99.999',    ROUND,   2, DECIMAL_PLACES, PAD_WITH_ZERO,  '100.00'],
    // ['-99.999',    ROUND,   2, DECIMAL_PLACES, PAD_WITH_ZERO, '-100.00'],
    // ['12.3456',    ROUND,  -1, DECIMAL_PLACES,    NO_PADDING,  '10'],  // not yet supported
    // ['123.456',    ROUND,  -1, DECIMAL_PLACES,    NO_PADDING,  '120'],  // not yet supported
    // ['123.456',    ROUND,  -2, DECIMAL_PLACES,    NO_PADDING,  '100'],  // not yet supported
    // a problematic case in PHP
    assert($exchange->decimal_to_precision('10000', ROUND, 6, DECIMAL_PLACES) === '10000');
    assert($exchange->decimal_to_precision('0.00003186', ROUND, 8, DECIMAL_PLACES) === '0.00003186');
    assert($exchange->decimal_to_precision('12.3456', ROUND, -1, DECIMAL_PLACES) === '10');
    assert($exchange->decimal_to_precision('123.456', ROUND, -1, DECIMAL_PLACES) === '120');
    assert($exchange->decimal_to_precision('123.456', ROUND, -2, DECIMAL_PLACES) === '100');
    assert($exchange->decimal_to_precision('9.99999', ROUND, -1, DECIMAL_PLACES) === '10');
    assert($exchange->decimal_to_precision('99.9999', ROUND, -1, DECIMAL_PLACES) === '100');
    assert($exchange->decimal_to_precision('99.9999', ROUND, -2, DECIMAL_PLACES) === '100');
    assert($exchange->decimal_to_precision('9.999', ROUND, 3, DECIMAL_PLACES) === '9.999');
    assert($exchange->decimal_to_precision('9.999', ROUND, 2, DECIMAL_PLACES) === '10');
    assert($exchange->decimal_to_precision('9.999', ROUND, 2, DECIMAL_PLACES, PAD_WITH_ZERO) === '10.00');
    assert($exchange->decimal_to_precision('99.999', ROUND, 2, DECIMAL_PLACES, PAD_WITH_ZERO) === '100.00');
    assert($exchange->decimal_to_precision('-99.999', ROUND, 2, DECIMAL_PLACES, PAD_WITH_ZERO) === '-100.00');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionRoundingToNSignificantDigits
    assert($exchange->decimal_to_precision('0.000123456700', ROUND, 100, SIGNIFICANT_DIGITS) === '0.0001234567');
    assert($exchange->decimal_to_precision('0.0001234567', ROUND, 100, SIGNIFICANT_DIGITS) === '0.0001234567');
    assert($exchange->decimal_to_precision('0.0001234567', ROUND, 7, SIGNIFICANT_DIGITS) === '0.0001234567');
    assert($exchange->decimal_to_precision('0.000123456', ROUND, 6, SIGNIFICANT_DIGITS) === '0.000123456');
    assert($exchange->decimal_to_precision('0.000123456', ROUND, 5, SIGNIFICANT_DIGITS) === '0.00012346');
    assert($exchange->decimal_to_precision('0.000123456', ROUND, 4, SIGNIFICANT_DIGITS) === '0.0001235');
    assert($exchange->decimal_to_precision('0.00012', ROUND, 2, SIGNIFICANT_DIGITS) === '0.00012');
    assert($exchange->decimal_to_precision('0.0001', ROUND, 1, SIGNIFICANT_DIGITS) === '0.0001');
    assert($exchange->decimal_to_precision('123.0000987654', ROUND, 7, SIGNIFICANT_DIGITS) === '123.0001');
    assert($exchange->decimal_to_precision('123.0000987654', ROUND, 6, SIGNIFICANT_DIGITS) === '123');
    assert($exchange->decimal_to_precision('0.00098765', ROUND, 2, SIGNIFICANT_DIGITS) === '0.00099');
    assert($exchange->decimal_to_precision('0.00098765', ROUND, 2, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '0.00099');
    assert($exchange->decimal_to_precision('0.00098765', ROUND, 1, SIGNIFICANT_DIGITS) === '0.001');
    assert($exchange->decimal_to_precision('0.00098765', ROUND, 10, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '0.0009876500000');
    assert($exchange->decimal_to_precision('0.098765', ROUND, 1, SIGNIFICANT_DIGITS, PAD_WITH_ZERO) === '0.1');
    assert($exchange->decimal_to_precision('0', ROUND, 0, SIGNIFICANT_DIGITS) === '0');
    assert($exchange->decimal_to_precision('-0.123', ROUND, 0, SIGNIFICANT_DIGITS) === '0');
    assert($exchange->decimal_to_precision('0.00000044', ROUND, 5, SIGNIFICANT_DIGITS) === '0.00000044');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionRoundingToTickSize
    assert($exchange->decimal_to_precision('0.000123456700', ROUND, 0.00012, \ccxt\TICK_SIZE) === '0.00012');
    assert($exchange->decimal_to_precision('0.0001234567', ROUND, 0.00013, \ccxt\TICK_SIZE) === '0.00013');
    assert($exchange->decimal_to_precision('0.0001234567', TRUNCATE, 0.00013, \ccxt\TICK_SIZE) === '0');
    assert($exchange->decimal_to_precision('101.000123456700', ROUND, 100, \ccxt\TICK_SIZE) === '100');
    assert($exchange->decimal_to_precision('0.000123456700', ROUND, 100, \ccxt\TICK_SIZE) === '0');
    assert($exchange->decimal_to_precision('165', TRUNCATE, 110, \ccxt\TICK_SIZE) === '110');
    assert($exchange->decimal_to_precision('3210', TRUNCATE, 1110, \ccxt\TICK_SIZE) === '2220');
    assert($exchange->decimal_to_precision('165', ROUND, 110, \ccxt\TICK_SIZE) === '220');
    assert($exchange->decimal_to_precision('0.000123456789', ROUND, 1.2e-7, \ccxt\TICK_SIZE) === '0.00012348');
    assert($exchange->decimal_to_precision('0.000123456789', TRUNCATE, 1.2e-7, \ccxt\TICK_SIZE) === '0.00012336');
    assert($exchange->decimal_to_precision('0.000273398', ROUND, 1e-7, \ccxt\TICK_SIZE) === '0.0002734');
    assert($exchange->decimal_to_precision('0.00005714', TRUNCATE, 1e-8, \ccxt\TICK_SIZE) === '0.00005714');
    // this line causes problems in JS, fix with Precise
    // assert (exchange.decimalToPrecision ('0.0000571495257361', TRUNCATE, 0.00000001, \ccxt\TICK_SIZE) === '0.00005714');
    assert($exchange->decimal_to_precision('0.01', ROUND, 0.0001, \ccxt\TICK_SIZE, PAD_WITH_ZERO) === '0.0100');
    assert($exchange->decimal_to_precision('0.01', TRUNCATE, 0.0001, \ccxt\TICK_SIZE, PAD_WITH_ZERO) === '0.0100');
    assert($exchange->decimal_to_precision('-0.000123456789', ROUND, 1.2e-7, \ccxt\TICK_SIZE) === '-0.00012348');
    assert($exchange->decimal_to_precision('-0.000123456789', TRUNCATE, 1.2e-7, \ccxt\TICK_SIZE) === '-0.00012336');
    assert($exchange->decimal_to_precision('-165', TRUNCATE, 110, \ccxt\TICK_SIZE) === '-110');
    assert($exchange->decimal_to_precision('-165', ROUND, 110, \ccxt\TICK_SIZE) === '-220');
    assert($exchange->decimal_to_precision('-1650', TRUNCATE, 1100, \ccxt\TICK_SIZE) === '-1100');
    assert($exchange->decimal_to_precision('-1650', ROUND, 1100, \ccxt\TICK_SIZE) === '-2200');
    assert($exchange->decimal_to_precision('0.0006', TRUNCATE, 0.0001, \ccxt\TICK_SIZE) === '0.0006');
    assert($exchange->decimal_to_precision('-0.0006', TRUNCATE, 0.0001, \ccxt\TICK_SIZE) === '-0.0006');
    assert($exchange->decimal_to_precision('0.6', TRUNCATE, 0.2, \ccxt\TICK_SIZE) === '0.6');
    assert($exchange->decimal_to_precision('-0.6', TRUNCATE, 0.2, \ccxt\TICK_SIZE) === '-0.6');
    assert($exchange->decimal_to_precision('1.2', ROUND, 0.4, \ccxt\TICK_SIZE) === '1.2');
    assert($exchange->decimal_to_precision('-1.2', ROUND, 0.4, \ccxt\TICK_SIZE) === '-1.2');
    assert($exchange->decimal_to_precision('1.2', ROUND, 0.02, \ccxt\TICK_SIZE) === '1.2');
    assert($exchange->decimal_to_precision('-1.2', ROUND, 0.02, \ccxt\TICK_SIZE) === '-1.2');
    assert($exchange->decimal_to_precision('44', ROUND, 4.4, \ccxt\TICK_SIZE) === '44');
    assert($exchange->decimal_to_precision('-44', ROUND, 4.4, \ccxt\TICK_SIZE) === '-44');
    assert($exchange->decimal_to_precision('44.00000001', ROUND, 4.4, \ccxt\TICK_SIZE) === '44');
    assert($exchange->decimal_to_precision('-44.00000001', ROUND, 4.4, \ccxt\TICK_SIZE) === '-44');
    // https://github.com/ccxt/ccxt/issues/6731
    assert($exchange->decimal_to_precision('20', TRUNCATE, 1e-8, \ccxt\TICK_SIZE) === '20');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionNegativeNumbers
    assert($exchange->decimal_to_precision('-0.123456', TRUNCATE, 5, DECIMAL_PLACES) === '-0.12345');
    assert($exchange->decimal_to_precision('-0.123456', ROUND, 5, DECIMAL_PLACES) === '-0.12346');
    // ----------------------------------------------------------------------------
    // decimalToPrecision: without dot / trailing dot
    assert($exchange->decimal_to_precision('123', TRUNCATE, 0) === '123');
    assert($exchange->decimal_to_precision('123', TRUNCATE, 5, DECIMAL_PLACES) === '123');
    assert($exchange->decimal_to_precision('123', TRUNCATE, 5, DECIMAL_PLACES, PAD_WITH_ZERO) === '123.00000');
    assert($exchange->decimal_to_precision('123.', TRUNCATE, 0, DECIMAL_PLACES) === '123');
    assert($exchange->decimal_to_precision('123.', TRUNCATE, 5, DECIMAL_PLACES, PAD_WITH_ZERO) === '123.00000');
    assert($exchange->decimal_to_precision('0.', TRUNCATE, 0) === '0');
    assert($exchange->decimal_to_precision('0.', TRUNCATE, 5, DECIMAL_PLACES, PAD_WITH_ZERO) === '0.00000');
    // ----------------------------------------------------------------------------
    // decimalToPrecision: rounding for equidistant digits
    assert($exchange->decimal_to_precision('1.44', ROUND, 1, DECIMAL_PLACES) === '1.4');
    assert($exchange->decimal_to_precision('1.45', ROUND, 1, DECIMAL_PLACES) === '1.5');
    assert($exchange->decimal_to_precision('1.45', ROUND, 0, DECIMAL_PLACES) === '1'); // not 2
    // ----------------------------------------------------------------------------
    // negative precision only implemented so far in python
    // pretty useless for decimal applications as anything |x| < 5 === 0
    // NO_PADDING and PAD_WITH_ZERO are ignored
    assert($exchange->decimal_to_precision('5', ROUND, -1, DECIMAL_PLACES) === '10');
    assert($exchange->decimal_to_precision('4.999', ROUND, -1, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('0.0431531423', ROUND, -1, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('-69.3', ROUND, -1, DECIMAL_PLACES) === '-70');
    assert($exchange->decimal_to_precision('5001', ROUND, -4, DECIMAL_PLACES) === '10000');
    assert($exchange->decimal_to_precision('4999.999', ROUND, -4, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('69.3', TRUNCATE, -2, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('-69.3', TRUNCATE, -2, DECIMAL_PLACES) === '0');
    assert($exchange->decimal_to_precision('69.3', TRUNCATE, -1, SIGNIFICANT_DIGITS) === '60');
    assert($exchange->decimal_to_precision('-69.3', TRUNCATE, -1, SIGNIFICANT_DIGITS) === '-60');
    assert($exchange->decimal_to_precision('69.3', TRUNCATE, -2, SIGNIFICANT_DIGITS) === '0');
    assert($exchange->decimal_to_precision('1602000000000000000000', TRUNCATE, 3, SIGNIFICANT_DIGITS) === '1600000000000000000000');
    // ----------------------------------------------------------------------------
    // decimal_to_precision: stringified precision
    assert($exchange->decimal_to_precision('-0.000123456789', ROUND, '0.00000012', \ccxt\TICK_SIZE) === '-0.00012348');
    assert($exchange->decimal_to_precision('-0.000123456789', TRUNCATE, '0.00000012', \ccxt\TICK_SIZE) === '-0.00012336');
    assert($exchange->decimal_to_precision('-165', TRUNCATE, '110', \ccxt\TICK_SIZE) === '-110');
    assert($exchange->decimal_to_precision('-165', ROUND, '110', \ccxt\TICK_SIZE) === '-220');
    // ----------------------------------------------------------------------------
    // testDecimalToPrecisionErrorHandling (todo)
    //
    // throws (() =>
    //     decimalToPrecision ('123456.789', TRUNCATE, -2, DECIMAL_PLACES),
    //         'negative precision is not yet supported')
    //
    // throws (() =>
    //     decimalToPrecision ('foo'),
    //         "invalid number (contains an illegal character 'f')")
    //
    // throws (() =>
    //     decimalToPrecision ('0.01', TRUNCATE, -1, \ccxt\TICK_SIZE),
    //         "\ccxt\TICK_SIZE cant be used with negative numPrecisionDigits")
    // ----------------------------------------------------------------------------
    $w = '-1.123e-6';
    $x = '0.00000002';
    $y = '69696900000';
    $z = '0';
    $a = '1e8';
    assert(Precise::string_mul($x, $y) === '1393.938');
    assert(Precise::string_mul($y, $x) === '1393.938');
    assert(Precise::string_add($x, $y) === '69696900000.00000002');
    assert(Precise::string_add($y, $x) === '69696900000.00000002');
    assert(Precise::string_sub($x, $y) === '-69696899999.99999998');
    assert(Precise::string_sub($y, $x) === '69696899999.99999998');
    assert(Precise::string_div($x, $y, 1) === '0');
    assert(Precise::string_div($x, $y) === '0');
    assert(Precise::string_div($x, $y, 19) === '0.0000000000000000002');
    assert(Precise::string_div($x, $y, 20) === '0.00000000000000000028');
    assert(Precise::string_div($x, $y, 21) === '0.000000000000000000286');
    assert(Precise::string_div($x, $y, 22) === '0.0000000000000000002869');
    assert(Precise::string_div($y, $x) === '3484845000000000000');
    assert(Precise::string_mul($x, $w) === '-0.00000000000002246');
    assert(Precise::string_mul($w, $x) === '-0.00000000000002246');
    assert(Precise::string_add($x, $w) === '-0.000001103');
    assert(Precise::string_add($w, $x) === '-0.000001103');
    assert(Precise::string_sub($x, $w) === '0.000001143');
    assert(Precise::string_sub($w, $x) === '-0.000001143');
    assert(Precise::string_div($x, $w) === '-0.017809439002671415');
    assert(Precise::string_div($w, $x) === '-56.15');
    assert(Precise::string_mul($z, $w) === '0');
    assert(Precise::string_mul($z, $x) === '0');
    assert(Precise::string_mul($z, $y) === '0');
    assert(Precise::string_mul($w, $z) === '0');
    assert(Precise::string_mul($x, $z) === '0');
    assert(Precise::string_mul($y, $z) === '0');
    assert(Precise::string_add($z, $w) === '-0.000001123');
    assert(Precise::string_add($z, $x) === '0.00000002');
    assert(Precise::string_add($z, $y) === '69696900000');
    assert(Precise::string_add($w, $z) === '-0.000001123');
    assert(Precise::string_add($x, $z) === '0.00000002');
    assert(Precise::string_add($y, $z) === '69696900000');
    assert(Precise::string_mul($x, $a) === '2');
    assert(Precise::string_mul($a, $x) === '2');
    assert(Precise::string_mul($y, $a) === '6969690000000000000');
    assert(Precise::string_mul($a, $y) === '6969690000000000000');
    assert(Precise::string_div($y, $a) === '696.969');
    assert(Precise::string_div($y, $a, -1) === '690');
    assert(Precise::string_div($y, $a, 0) === '696');
    assert(Precise::string_div($y, $a, 1) === '696.9');
    assert(Precise::string_div($y, $a, 2) === '696.96');
    assert(Precise::string_div($a, $y) === '0.001434784043479695');
    assert(Precise::string_abs('0') === '0');
    assert(Precise::string_abs('-0') === '0');
    assert(Precise::string_abs('-500.1') === '500.1');
    assert(Precise::string_abs('213') === '213');
    assert(Precise::string_neg('0') === '0');
    assert(Precise::string_neg('-0') === '0');
    assert(Precise::string_neg('-500.1') === '500.1');
    assert(Precise::string_neg('213') === '-213');
    assert(Precise::string_mod('57.123', '10') === '7.123');
    assert(Precise::string_mod('18', '6') === '0');
    assert(Precise::string_mod('10.1', '0.5') === '0.1');
    assert(Precise::string_mod('10000000', '5555') === '1000');
    assert(Precise::string_mod('5550', '120') === '30');
    assert(Precise::string_equals('1.0000', '1'));
    assert(Precise::string_equals('-0.0', '0'));
    assert(Precise::string_equals('-0.0', '0.0'));
    assert(Precise::string_equals('5.534000', '5.5340'));
    assert(Precise::string_min('1.0000', '2') === '1');
    assert(Precise::string_min('2', '1.2345') === '1.2345');
    assert(Precise::string_min('3.1415', '-2') === '-2');
    assert(Precise::string_min('-3.1415', '-2') === '-3.1415');
    assert(Precise::string_min('0.000', '-0.0') === '0');
    assert(Precise::string_max('1.0000', '2') === '2');
    assert(Precise::string_max('2', '1.2345') === '2');
    assert(Precise::string_max('3.1415', '-2') === '3.1415');
    assert(Precise::string_max('-3.1415', '-2') === '-2');
    assert(Precise::string_max('0.000', '-0.0') === '0');
    assert(!Precise::string_gt('1.0000', '2'));
    assert(Precise::string_gt('2', '1.2345'));
    assert(Precise::string_gt('3.1415', '-2'));
    assert(!Precise::string_gt('-3.1415', '-2'));
    assert(!Precise::string_gt('3.1415', '3.1415'));
    assert(Precise::string_gt('3.14150000000000000000001', '3.1415'));
    assert(!Precise::string_ge('1.0000', '2'));
    assert(Precise::string_ge('2', '1.2345'));
    assert(Precise::string_ge('3.1415', '-2'));
    assert(!Precise::string_ge('-3.1415', '-2'));
    assert(Precise::string_ge('3.1415', '3.1415'));
    assert(Precise::string_ge('3.14150000000000000000001', '3.1415'));
    assert(Precise::string_lt('1.0000', '2'));
    assert(!Precise::string_lt('2', '1.2345'));
    assert(!Precise::string_lt('3.1415', '-2'));
    assert(Precise::string_lt('-3.1415', '-2'));
    assert(!Precise::string_lt('3.1415', '3.1415'));
    assert(Precise::string_lt('3.1415', '3.14150000000000000000001'));
    assert(Precise::string_le('1.0000', '2'));
    assert(!Precise::string_le('2', '1.2345'));
    assert(!Precise::string_le('3.1415', '-2'));
    assert(Precise::string_le('-3.1415', '-2'));
    assert(Precise::string_le('3.1415', '3.1415'));
    assert(Precise::string_le('3.1415', '3.14150000000000000000001'));
}