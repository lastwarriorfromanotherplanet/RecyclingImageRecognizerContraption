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
                Name = "3D Printed Plastic",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevernt accidental injuries.",
                IsRecyclable = false
            },
            new() {
                Name = "Adhesive Tapes",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false
            },
            new()
            {
                Name = "Air Conditioners and Dehumidifiers",
                Category = "Special Items",
                DescriptionText = "Be aware that refrigerators and freezers can pose a serious suffocation hazard to children who may be playing in the area. Please remove doors. Items can be brought to our 7-in-1 events or to a metal recycler/ scrap yard. \nThe refrigerant gas used in these items is harmful to the environment. A licensed air conditioning technician must remove this gas and certify the item prior to drop-off.",
                IsRecyclable = false,
                HasDropOffEvents = true
            },
            new()
            {
                Name = "Air Purifiers and Vaporizers",
                Category = "Electronic Waste",
                DescriptionText = "Battery-operated and electric devices require special processing to recover the materials they're made from. Please bring them to an electronics recycling drop-off location.\nBe sure to remove any batteries from the device (these locations accept the batteries too).",
                IsRecyclable = false,
                HasDropOffEvents = true,
                RecycleCoachLink = "https://www.recyclecoach.com/blog/an-introduction-to-e-waste"
            },
            
            new() {
                Name = "Airbags",
                Category = "Miscellaneous",
                DescriptionText = "Please call us at (219) 363-1450 or (219) 326-0014 for more information.",
                IsRecyclable = false
            },
            new() {
                Name = "Aluminum Foil Containers and Wrap",
                Category = "Metals",
                DescriptionText = "Aluminum foil wrap, foil containers and lids that are 100% aluminum foil are accepted for recycling. Must be empty and clean - absolutely no food residue permitted. Scrunch foil into a loose ball.",
                IsRecyclable = true,
                HasCollectionRequirements = true,
                HasWhatHappensNext = true,
            },
            new() {
                Name = "Amazon Boxes",
                Category = "Cardboard",
                DescriptionText = "Plastic shipping pillows can be deflated and recycled anywhere that accepts plastic bags/films for recycling. ",
                IsRecyclable = true,
                HasCollectionRequirements = true
            },
            new() {
                Name = "Area Rugs",
                Category = "Bulky Items",
                DescriptionText = "Donation or Reuse is the preferred option for items in good condition. Alternatively, contact your waste hauler for pickup. These items are not recyclable. ",
                IsRecyclable = false,
                HasHaulerInfo = true,
                HasReuseOptions = true
               
            },
            new() {
                Name = "Artificial Christmas Trees",
                Category = "Bulky Items",
                DescriptionText = "Donation or reuse is the preferred option for items in good condition. Alternatively, contact your waste hauler for disposal instructions. These items are not recyclable. ",
                IsRecyclable = false,
                HasHaulerInfo = true,
            },
            new() {
                Name = "Asbestos",
                Category = "Miscellaneous",
                DescriptionText = "Please call us at (219) 363-1450 or (219) 326-0014 for more information.",
                IsRecyclable = false
            },
            new() {
                Name = "Ashes",
                Category = "Household Organics",
                DescriptionText = "Organic materials such as fresh or dried flowers, toothpicks, hair, feathers, and small quantities of sawdust are suitable for at home composting, or are accepted as trash",
                IsRecyclable = false,
                HasCollectionRequirements = true,
                HasAboutComposting = true,
            },
            new() {
                Name = "Asphalt Singles",
                Category = "Construction Waste",
                DescriptionText = "Demolition and renovation materials are not always accepted as regular garbage. Please contact your trash hauler for instructions on disposal. \n Some charitable organizations such as Habitat for Humanity ReStores may accept fixtures and other items that can be sold for reuse.",
                IsRecyclable = false,
                HasHaulerInfo = true,
                RecycleCoachLink = "https://www.recyclecoach.com/blog/how-to-reuse-and-recycle-construction-materials"
            },
            new()
            {
                Name = "Audio and Video Devices",
                Category = "Electronic Waste",
                DescriptionText = "All audio and video devices, including software and wiring, require special processing to recover the materials they're made from. Please bring them to an electronics recycling drop-off location. We are unable to accept dvds, cds, and vhs tapes at this time. ",
                IsRecyclable = false,
                HasDropOffEvents = true,
                HasDropOffLocations = true,
                RecycleCoachLink = "https://www.recyclecoach.com/blog/an-introduction-to-e-waste"
            },
            new()
            {
                Name = "Automotive Fluids, Filters and Containers",
                Category = "Household Hazardous Waste",
                DescriptionText = "Automotive fluids are not accepted in any garbage or recycling program. Please protect our environment by bringing them to a hazardous waste drop-off event.\nOther products such as paint, pesticides, compact fluorescent light bulbs, smoke detectors and batteries can also be harmful if not disposed of safely at a hazardous waste drop-off location.\nOccasionally auto part stores will accept these fluids. Please call them for more information. ",
                IsRecyclable = false,
                HasUsedOilRecycling = true,
                HasAboutHazardousWaste = true,
                VideoLink = "https://www.youtube.com/watch?v=NplprEGyFKw"
            },
            new()
            {
                Name = "Baby Wipes",
                Category = "Trash",
                DescriptionText = "Safe disposal of these items can mean preventing the spread of germs. Place them in a plastic bag, tie the bag securely and then place it in the trash. See below for more safe disposal information.\nREMINDER: Do not flush these products down the toilet. These items do not break down quickly enough in the wastewater system - or at all - and can end up clogging sewers and pipes. Even if products claim to be flushable, these items should go in the trash.\nFor up to date advice on disposal of masks and other materials where viruses like COVID-19 can reside, please refer to the World Health Organization's public advice.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Baby Wipes Plastic Packaging",
                Category = "trash",
                DescriptionText = "Baby Wipes Plastic Packaging\nPlace items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Bale Wraps",
                Category = "Miscellaneous",
                DescriptionText = "Please call us at (219) 363-1450 or (219) 326-0014 for more information.",
                IsRecyclable = false
            },
            new()
            {
                Name = "Balloons",
                Category = "trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Bamboo Containers",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Bamboo Cutlery",
                Category = "trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Barbecues",
                Category = "Bulky Items",
                DescriptionText = "Donation or reuse is the preferred option for items in good condition. Alternatively bring items to a metal recycler/ scrap yard. ",
                IsRecyclable = false,
                HasDropOffEvents = true,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Bathroom Fixtures",
                Category = "Construction Waste",
                DescriptionText = "Demolition and renovation materials are not always accepted as regular garbage. Please contact your trash hauler for instructions on disposal.\nSome charitable organizations such as Habitat for Humanity ReStores may accept fixtures and other items that can be sold for reuse.",
                IsRecyclable = false,
                HasHaulerInfo = true,
                RecycleCoachLink ="https://www.recyclecoach.com/blog/how-to-reuse-and-recycle-construction-materials"
            },
            new()
            {
                Name = "Battery Operated Devices",
                Category = "Electronic Waste",
                DescriptionText = "Battery-operated and electric devices require special processing to recover the materials they're made from. Please bring them to an electronics recycling drop-off location.\nBe sure to remove any batteries from the device (these locations accept the batteries too).",
                IsRecyclable = false,
                HasDropOffEvents=true,
                HasDropOffLocations = true,
                RecycleCoachLink = "https://www.recyclecoach.com/blog/an-introduction-to-e-waste"
            },
            new()
            {
                Name = "Beer Can Plastic Rings and Handles",
                Category = "Trash",
                DescriptionText = "These types of plastic handles are made from 100% recycled plastic but are too small to be accepted by your curbside recycling program.  \nThese need to be cut up and placed in the trash. \nAlternatively, they can be recycled at a Paktech drop off location.",
                IsRecyclable = false,
                HasExternalLink = "https://paktech-opi.com/recycling-drop-off/"
            },
            new()
            {
                Name = "Bicycles, Tricycles, and Scooters",
                Category = "Bulky Items",
                DescriptionText = "Donation or reuse is the preferred option for items in good condition. Alternatively bring items to a metal recycler/ scrap yard. ",
                IsRecyclable = false,
                HasHaulerInfo = true,
                HasDropOffEvents = true
            },
            new()
            {
                Name = "Blister Packaging",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = true,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Boat Wrap",
                Category = "Miscellaneous",
                DescriptionText = "Please call us at (219) 363-1450 or (219) 326-0014 for more information.",
                IsRecyclable = false
            },
            new()
            {
                Name = "Boats",
                Category = "Miscellaneous",
                DescriptionText = "Please call us at (219) 363-1450 or (219) 326-0014 for more information.",
                IsRecyclable = false
            },
            new()
            {
                Name = "Books",
                Category = "Recycling",
                DescriptionText = "Hard covers, like the ones on textbooks, must be removed and discarded before recycling. Please consider giving away books that someone else might enjoy.\nYou can drop-off books for donation in the drop-off bin at the Solid Waste District office. See Drop-off for more.",
                IsRecyclable = true,
                HasReuseOptions = true,
                HasWhatHappensNext = true,
                HasDropOffLocations = true,
                HasCollectionRequirements = true,
            },
            new()
            {
                Name = "Boots, Shoes, Sandals, and Slippers",
                Category = "Donation Drop-off",
                DescriptionText = "Most textile programs accept more than just clothing in good condition. Many items in poor condition can be broken down and recycled into new products, including towels, bedding and footwear.\n",
                IsRecyclable = false
            },
            new()
            {
                Name = "Box Springs",
                Category = "Bulky Items",
                DescriptionText = "Donation or reuse is the preferred option for items in good condition. Alternatively, contact your waste hauler for pickup. These items are not recyclable. ",
                IsRecyclable = false,
                HasHaulerInfo = true,
                HasReuseOptions = true
            },
            new()
            {
                Name = "Bread Bags",
                Category = "Drop-Off",
                DescriptionText = "Plastic films/bags are not accepted in curbside recycling toters. They can be recycled anywhere that accepts plastic bags / films for recycling including at our office where we have a collection bin. \n",
                IsRecyclable = false,
                HasDropOffLocations = true,
                RecycleCoachLink = "https://www.recyclecoach.com/blog/all-you-need-to-know-about-plastic-bag-recycling",
                HasWhatHappensNext = true
                
            },
            new()
            {
                Name = "Bread Tags",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Brita Filters",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Bubble Lined Paper Envelopes", 
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.", 
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Burlap Sacks",
                Category = "Household Organics",
                DescriptionText = "Organic materials such as fresh or dried flowers, toothpicks, hair, feathers, and small quantities of sawdust are suitable for at home composting, or are accepted as trash.",
                IsRecyclable = false,
                HasCollectionRequirements = true,
                HasAboutComposting = true,
            },
            new()
            {
                Name = "Candles",
                Category = "Trash",
                DescriptionText = "Household items that are in good condition can often be sold at a yard sale, given away, or donated to charity. Put items in poor condition in the trash.\n",
                IsRecyclable = false,
                HasHaulerInfo = true,
                HasReuseOptions = true
            },
            new()
            {
                Name = "Candy Wrappers",
                Category = "Trash",
                DescriptionText = "Place items that are not hazardous or recyclable in the trash. Be careful with things like broken glass to prevent accidental injuries.",
                IsRecyclable = false,
                HasHaulerInfo = true
            },
            new()
            {
                Name = "Capacitors",
                Category = "Miscellaneous",
                DescriptionText = "Please call us at (219) 363-1450 or (219) 326-0014 for more information",
                IsRecyclable = false
            },
            

        };

        await _laPorteService.AddItemListAsync(itemList);
        var status = _laPorteService.StatusMessage;
    }
}
