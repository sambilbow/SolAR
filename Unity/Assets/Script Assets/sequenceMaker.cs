﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioHelm;

public class sequenceMaker : MonoBehaviour {
        
		
        public int[] scale = { 0, 2, 4, 7, 9 };

        public int minNote = 48;
        public int octaveSpan = 2;
        public float minDensity = 0.5f;
        public float maxDensity = 1.0f;

        void GenerateRhythm()
        {
        }

        void GenerateMelody()
        {
        }

        void Start()
        {
            Generate();
        }

        int GetKeyFromRandomWalk(int note)
        {
            int octave = note / scale.Length;
            int scalePosition = note % scale.Length;
            return minNote + octave * Utils.kNotesPerOctave + scale[scalePosition];
        }

        int GetNextNote(int current, int max)
        {
            int next = current + Random.Range(-3, 3);

            if (next > max)
                return 2 * max - next;
            if (next < 0)
                return Mathf.Abs(next);

            return next;
        }

        public void Generate()
        {
			Sequencer  sequencer = this.gameObject.GetComponent<HelmSequencer>(); 
            sequencer.Clear();

            int maxNote = scale.Length * octaveSpan;
            int currentNote = Random.Range(0, maxNote);
            Note lastNote = sequencer.AddNote(GetKeyFromRandomWalk(currentNote), 0, 1);

            for (int i = 1; i < sequencer.length; ++i)
            {
                float density = Random.Range(minDensity, maxDensity);

                if (Random.Range(0.0f, 1.0f) < density)
                {
                    currentNote = GetNextNote(currentNote, maxNote);
                    lastNote = sequencer.AddNote(GetKeyFromRandomWalk(currentNote), i, i + 1);
                }
                else
                    lastNote.end = i + 1;
            }
        }
    }