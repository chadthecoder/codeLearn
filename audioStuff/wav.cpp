#include <iostream>
#include <fstream>
#include <cmath>

void write_as_bytes(std::ofstream &file, int value, int byte_size)
{
    file.write(reinterpret_cast<const char*>(&value), byte_size);
}

//PCM header is default for now
//0 for mono and 1 for stereo 
int setHeader(std::string waveType, bool stereo)
{
    //RIFF chunk
    const std::string chunk_id = "RIFF";
    const std::string chunk_size = "----";
    const std::string format = "WAVE";

    //FMT sub-chunk
    const std::string subchunk1_id = "fmt ";
    const int subchunk1_size = 16;
    const int audio_format = 1;

    //set to default of stereo but should just use parameter
    //1 for mono, 2 for stereo
    int num_channels = 2;
    if(stereo) num_channels = 2;
    else num_channels = 1;

    const int sample_rate = 44100;
    const int byte_rate = sample_rate * num_channels * subchunk1_size/8;
    const int block_align = num_channels * (subchunk1_size / 8) ;
    const int bits_per_sample = 16;

    //subchunk2
    const std::string subchunk2_id = "data";
    const std::string subchunk2_size = "----";
}

int main(int argc, char **argv)
{
    //true for stereo
    setHeader("PCM", true);
    return 0;
}