using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecyclingImageRecognizerContraption.Resources.Models;

namespace RecyclingImageRecognizerContraption.Resources.DatabaseService;

public class AddDatabase(LaPorteService laPorteService)
{
    private readonly LaPorteService _laPorteService = laPorteService;

    public async Task FillDatabase()
    {
        var itemList = new List<LaPorte>
        {
            new()
            {
                Name = "Cardboard Boxes",
                Category = "Recycling",
                DescriptionText = "Flatten boxes and place in or on the side of your recycling toter. Please do not tie in a bundle.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
            },
            new()
            {
                Name = "Cardboard Packaging",
                Category = "Recycling",
                DescriptionText = "Boxboard packaging of the type used for cereal, shoes, laundry detergent and paper towel cores is accepted for recycling. Remove and dispose of any plastic or foil liners or wrap. Flatten boxes",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
            },
            new()
            {
                Name = "Clothing",
                Category = "Donation Drop-Off",
                DescriptionText = "Most textile programs accept more than just clothing in good condition. Many items in poor condition can be broken down and recycled into new products, including towels, bedding and footwear.",
                IsRecyclable = false
            },
            new()
            {
                Name = "Coffee Grounds",
                Category = "Trash",
                DescriptionText = "Coffee grounds are a wonderful addition to your compost pile. If you don't have a compost pile, consider starting one!",
                IsRecyclable = false,
                HasCollectionRequirements = true

            },
            new()
            {
                Name = "Plastic Cutlery",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Egg Shells",
                Category = "Trash",
                DescriptionText = "Most spoiled and leftover food is suitable for at home composting and is accepted as garbage. Materials like meat, fish, dairy are not suitable for composting and should be put in the garbage.",
                IsRecyclable = false,
                HasCollectionRequirements = true,
                HasAboutComposting = true
            },
            new()
            {
                Name = "Food Waste",
                Category = "Trash",
                DescriptionText = "Most spoiled and leftover food is suitable for at home composting and is accepted as garbage. Materials like meat, fish, dairy are not suitable for composting and should be put in the garbage.",
                IsRecyclable = false,
                HasCollectionRequirements = true,
                HasAboutComposting = true
            },
            new()
            {
                Name = "Glass Bottles",
                Category = "Recycling",
                DescriptionText = "Leave caps on if possible, otherwise dispose of caps/lids in the trash.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Glass Food Jars",
                Category = "Recycling",
                DescriptionText = "Leave caps on if possible, otherwise dispose of caps/lids in the trash.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Magazines",
                Category = "Recycling",
                DescriptionText = "Most paper items are recyclable provided they don't contain grease, food residue or a wax coating. Things like glue, tape, staples and envelope windows are ok, but be sure to remove plastic wrappers.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
                //Has external Link
            },
            new()
            {
                Name = "Newspaper",
                Category = "Recycling",
                DescriptionText = "Most paper items are recyclable provided they don't contain grease, food residue or a wax coating. Things like glue, tape, staples and envelope windows are ok, but be sure to remove plastic wrappers.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Office Paper",
                Category = "Recycling",
                DescriptionText = "Most paper items are recyclable provided they don't contain grease, food residue or a wax coating. Things like glue, tape, staples and envelope windows are ok, but be sure to remove plastic wrappers.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Paper Cups",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Plastic Cups",
                Category = "Recycling",
                DescriptionText = "All plastic bottles, jars, tubs, trays and containers with #1-7 on the bottom are accepted. Must be empty and rinsed clean. Remove and discard cap, pump or sprayer. Recycle tubs with lid attached.\r\n\r\n#6 plastics need to be placed in the garbage.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true,
                //Has External Link
            },
            new()
            {
                Name = "Plastic Lids",
                Category = "Recycling",
                DescriptionText = "All plastic bottles, jars, tubs, trays and containers with #1-7 on the bottom are accepted. Must be empty and rinsed clean. Remove and discard cap, pump or sprayer. Recycle tubs with lid attached.\r\n\r\n#6 plastics need to be placed in the garbage.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true,
                //Has External Link
            },
            new()
            {
                Name = "Plastic Detergent Bottles",
                Category = "Recycling",
                DescriptionText = "All plastic bottles, jars, tubs, trays and containers with #1-7 on the bottom are accepted. Must be empty and rinsed clean. Remove and discard cap, pump or sprayer. Recycle tubs with lid attached.\r\n\r\n#6 plastics need to be placed in the garbage.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true,
            },
            new()
            {
                Name = "Plastic Food Containers",
                Category = "Recycling",
                DescriptionText = "All plastic bottles, jars, tubs, trays and containers with #1-7 on the bottom are accepted. Must be empty and rinsed clean. Remove and discard cap, pump or sprayer. Recycle tubs with lid attached.\r\n\r\n#6 plastics need to be placed in the garbage.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Plastic Shopping Bags",
                Category = "Recycling Drop-Off",
                DescriptionText = "Plastic films/bags are not accepted in curbside recycling toters. They can be recycled anywhere that accepts plastic bags/ films for recycling including at our office where we have a collection bin.",
                IsRecyclable = false,
                HasDropOffLocations = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Plastic Soda Bottles",
                Category = "Recycling",
                DescriptionText = "All plastic bottles, jars, tubs, trays and containers with #1-7 on the bottom are accepted. Must be empty and rinsed clean. Remove and discard cap, pump or sprayer. Recycle tubs with lid attached.\r\n\r\n#6 plastics need to be placed in the garbage.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true,
            },
            new()
            {
                Name = "Plastic Straws",
                Category = "Trash",
                DescriptionText = "Single-use plastic straws and stir sticks go in the trash. For more sustainable alternatives, consider going straw-less or purchase a reusable straw.",
                IsRecyclable = false,
                HasHaulerInfo = true
                //Has External Link
            },
            new()
            {
                Name = "Plastic Trash Bags",
                Category = "Recycling Drop-Off",
                DescriptionText = "Plastic films/bags are not accepted in curbside recycling toters. They can be recycled anywhere that accepts plastic bags/ films for recycling including at our office where we have a collection bin.",
                IsRecyclable = true,
                HasDropOffLocations = true,
                HasWhatHappensNext = true
                //Has External Link
            },
            new()
            {
                Name = "Plastic Water Bottles",
                Category = "Recycling",
                DescriptionText = "All plastic bottles, jars, tubs, trays and containers with #1-7 on the bottom are accepted. Must be empty and rinsed clean. Remove and discard cap, pump or sprayer. Recycle tubs with lid attached.\r\n\r\n#6 plastics need to be placed in the garbage.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true,
            },
            new()
            {
                Name = "Styrofoam Cups",
                Category = "Recycling Drop-Off",
                DescriptionText = "Styrofoam is not accepted in the curbside recycling program. It can be brought to either the Spring or Fall HHW events to be recycled.",
                HasDropOffEvents = true,
                HasWhatHappensNext = true
            },
            new()
            {
                Name = "Styrofoam Food Containers",
                Category = "Recycling Drop-Off",
                DescriptionText = "Styrofoam is not accepted in the curbside recycling program. It can be brought to either the Spring or Fall HHW events to be recycled.",
                IsRecyclable = true,
                HasDropOffEvents = true,
                HasWhatHappensNext = true
            },
            new()
            {
                Name = "Tea Bags",
                Category = "Household Organics",
                DescriptionText = "Most spoiled and leftover food is suitable for at home composting and is accepted as garbage. Materials like meat, fish, dairy are not suitable for composting and should be put in the garbage.",
                IsRecyclable = false,
                HasCollectionRequirements = true,
                HasAboutComposting = true
                //Has External Link
                
            }

        };

        await _laPorteService.AddItemListAsync(itemList);
        var status = _laPorteService.StatusMessage;
    }
}
