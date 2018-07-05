﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GL_TXT
{
    public static void Draw_Glyph(char _char, float _x, float _y, float _size, Color _col)
    {
        BitArray _CELLS = GL_FONT_3x5.Get(_char);
        GL_DRAW.Draw_MATRIX_RECT(_x, _y, _size * 3, -GL_DRAW.LockAspect_Y(_size * 5), 3, 5, _col, _CELLS);
    }

    public static void Draw_TXT(string _str, float _x, float _y, float _cellSize, Color _col){
        float _CHAR_WIDTH = _cellSize * 3;
        for (int i = 0; i < _str.Length; i++)
        {
            Draw_Glyph(_str[i], _x + (_CHAR_WIDTH * i) + (_cellSize * i), _y,_cellSize, _col);
        }
    }
}

public class GL_FONT_3x5
{

    public static Dictionary<char, BitArray> glpyhs = new Dictionary<char, BitArray>();
    public static void Init()
    {
        glpyhs.Add('0', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('1', Set(new int[] { 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0 }));
        glpyhs.Add('2', Set(new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 }));
        glpyhs.Add('3', Set(new int[] { 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1 }));
        glpyhs.Add('4', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 }));
        glpyhs.Add('5', Set(new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 }));
        glpyhs.Add('6', Set(new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('7', Set(new int[] { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 }));
        glpyhs.Add('8', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('9', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 }));

        glpyhs.Add('a', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 }));
        glpyhs.Add('b', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('c', Set(new int[] { 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1 }));
        glpyhs.Add('d', Set(new int[] { 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0 }));
        glpyhs.Add('e', Set(new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1 }));
        glpyhs.Add('f', Set(new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0 }));
        glpyhs.Add('g', Set(new int[] { 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('h', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 }));
        glpyhs.Add('i', Set(new int[] { 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1 }));
        glpyhs.Add('j', Set(new int[] { 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('k', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1 }));
        glpyhs.Add('l', Set(new int[] { 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1 }));
        glpyhs.Add('m', Set(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 }));
        glpyhs.Add('n', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1 }));
        glpyhs.Add('o', Set(new int[] { 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0 }));
        glpyhs.Add('p', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0 }));
        glpyhs.Add('q', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 }));
        glpyhs.Add('r', Set(new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1 }));
        glpyhs.Add('s', Set(new int[] { 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1 }));
        glpyhs.Add('t', Set(new int[] { 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0 }));
        glpyhs.Add('u', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 }));
        glpyhs.Add('v', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0 }));
        glpyhs.Add('w', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        glpyhs.Add('x', Set(new int[] { 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1 }));
        glpyhs.Add('y', Set(new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 }));
        glpyhs.Add('z', Set(new int[] { 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1 }));
    }
    private static BitArray Set(int[] _cells)
    {
        BitArray result = new BitArray(_cells.Length);
        for (int i = 0; i < _cells.Length; i++)
        {
            result[i] = (_cells[i] == 1) ? true : false;
        }
        return result;
    }
    public static BitArray Get(char _char)
    {
        return glpyhs[_char];
    }
}